using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter.Obfuscator.Class
{
    class Randomization
    {
        public static void Execute(ModuleDef module)
        {

            module.Name = "by-unknown" + Randomize.RandomCharacters(25);
            module.EntryPoint.Name = "by-unknown" + Randomize.RandomCharacters(25);
            module.EncBaseId = Guid.NewGuid();
            module.EncId = Guid.NewGuid();
            module.Mvid = Guid.NewGuid();

            foreach (var type in module.GetTypes())
            {
                type.Namespace = string.Empty;
                type.Name = "by-unknown" + Randomize.RandomCharacters(25);
            }

            foreach(TypeDef type in module.Types)
            {
                foreach (MethodDef paramMethod in type.Methods)
                {
                    foreach (ParamDef param in paramMethod.ParamDefs)
                    {
                        param.Name = "by-unknown" + Randomize.RandomCharacters(25);
                    }
                }

                foreach (EventDef @event in type.Events)
                {
                    @event.Name = "by-unknown" + Randomize.RandomCharacters(25);
                }

                foreach (FieldDef field in type.Fields)
                {
                    field.Name = "by-unknown" + Randomize.RandomCharacters(25);
                }

                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody) continue;

                    if (method.IsConstructor) continue;
                    method.Name = "by-unknown" + Randomize.RandomCharacters(25);
                }

                foreach (MethodDef strings in type.Methods)
                {
                    if (!strings.HasBody) continue;
                    for (int i = 0; i < strings.Body.Instructions.Count(); i++)
                    {

                        if (strings.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            String regString = strings.Body.Instructions[i].Operand.ToString();
                            String encString = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(regString));
                            Console.WriteLine($"{regString} -> {encString}");
                            strings.Body.Instructions[i].OpCode = OpCodes.Nop;
                            strings.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, module.Import(typeof(System.Text.Encoding).GetMethod("get_UTF8", new Type[] { }))));
                            strings.Body.Instructions.Insert(i + 2, new Instruction(OpCodes.Ldstr, encString));
                            strings.Body.Instructions.Insert(i + 3, new Instruction(OpCodes.Call, module.Import(typeof(System.Convert).GetMethod("FromBase64String", new Type[] { typeof(string) }))));
                            strings.Body.Instructions.Insert(i + 4, new Instruction(OpCodes.Callvirt, module.Import(typeof(System.Text.Encoding).GetMethod("GetString", new Type[] { typeof(byte[]) }))));
                            i += 4;
                        }
                    }
                }

                module.Assembly.Name = "by-unknown" + Randomize.RandomCharacters(25);


                string[] attri = { "AssemblyVersionAttribute", "AssemblyDescriptionAttribute",
                    "AssemblyTitleAttribute", "AssemblyProductAttribute", "AssemblyCopyrightAttribute",
                    "AssemblyCompanyAttribute", "AssemblyFileVersionAttribute", "GuidAttribute", "TargetFrameworkAttribute",
                    "TargetFrameworkAttribute.FrameworkDisplayName", "AssemblyConfigurationAttribute", "AssemblyTrademarkAttribute",};

                foreach (CustomAttribute attribute in module.Assembly.CustomAttributes)
                {
                    if (attri.Any(attribute.AttributeType.Name.Contains))
                    {
                        string encAttri = "by-unknown" + Randomize.RandomCharacters(25);

                        attribute.ConstructorArguments[0] = new CAArgument(module.CorLibTypes.String, new UTF8String(encAttri));
                    }
                }
            }
        }
    }
}
