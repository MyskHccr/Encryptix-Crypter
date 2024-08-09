using Crypter.Obfuscator.Class;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter.Obfuscator
{
    internal class Obfuscate
    {
        public void Execute(ModuleDefMD module)
        {
            Randomization.Execute(module);
            Booster.Execute(module);
        }
    }
}
