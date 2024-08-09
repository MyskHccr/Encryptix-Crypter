using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter.Core
{
    public struct Settings
    {

        public string buildDirectory { get; set; }
        public string payloadName;
        public string resourceName;
        public string decryptKey;
        public string stubResources;
        public string encryptedPayload;
        public string injectionType;
        public string injectionName;
        public EncryptionType encryptionType;
        


        public string fileName;
        public string specialDir;
        public string regeditName;
        public string schtasksName;
        public string folderName;
        public bool doRegedit;
        public bool doSchtasks;
        public bool doInstall;


        public int sleep;
        public bool doSleep;
        public bool doAntiVM;
        public bool HIDDENFILE;

        public string AssemblyTitle;
        public string AssemblyDescription;
        public string AssemblyProduct;
        public string AssemblyCompany;
        public string AssemblyCopyright;
        public string AssemblyTrademark;
        public string AssemblyMajorVersion;
        public string AssemblyMinorVersion;
        public string AssemblyBuildPart;
        public string AssemblyPrivatePart;
        public string AssemblyIcon;
    }
}
