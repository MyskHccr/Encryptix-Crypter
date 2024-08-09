using Crypter.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter.Forms
{

    public partial class FormInformation : Form
    {

        private Settings settings;
        private readonly RandomFileInfo randomFileInfo;
        private readonly RandomCharacters randomCharacters;

        public FormInformation()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.randomCharacters = new RandomCharacters();
            this.randomFileInfo = new RandomFileInfo(randomCharacters);
        }
        private void FormInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            TxtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtProduct.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtCopyright.Text = string.Empty;
            txtTrademark.Text = string.Empty;
            assemblyMajorVersion.Text = string.Empty;
            assemblyMinorVersion.Text = string.Empty;
            assemblyBuildPart.Text = string.Empty;
            assemblyPrivatePart.Text = string.Empty;
            txtIcon.Text = string.Empty;
            iconOXO.ImageLocation = string.Empty;
            iconOXO.BorderStyle = BorderStyle.None;
        }

        private void iconBtn_Click_1(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Icon (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIcon.Text = openFileDialog.FileName;
                    iconOXO.ImageLocation = openFileDialog.FileName;
                    iconOXO.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    txtIcon.Text = string.Empty;
                    iconOXO.ImageLocation = string.Empty;
                }
            }
        }

        private void rndmSelect_Click(object sender, EventArgs e)
        {
            var newInfo = randomFileInfo.getRandomFileInfo();
            TxtTitle.Text = newInfo.Title;
            txtDescription.Text = newInfo.Description;
            txtProduct.Text = newInfo.Product;
            txtCompany.Text = newInfo.Company;
            txtCopyright.Text = newInfo.Copyright;
            txtTrademark.Text = newInfo.Trademark;
            assemblyMajorVersion.Text = newInfo.MajorVersion;
            assemblyMinorVersion.Text = newInfo.MinorVersion;
            assemblyBuildPart.Text = newInfo.BuildPart;
            assemblyPrivatePart.Text = newInfo.PrivatePart;
        }

        private void cloneBtn_Click_1(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);

                    TxtTitle.Text = fileVersionInfo.InternalName ?? string.Empty;
                    txtDescription.Text = fileVersionInfo.FileDescription ?? string.Empty;
                    txtProduct.Text = fileVersionInfo.CompanyName ?? string.Empty;
                    txtCompany.Text = fileVersionInfo.ProductName ?? string.Empty;
                    txtCopyright.Text = fileVersionInfo.LegalCopyright ?? string.Empty;
                    txtTrademark.Text = fileVersionInfo.LegalTrademarks ?? string.Empty;

                    assemblyMajorVersion.Text = fileVersionInfo.FileMajorPart.ToString();
                    assemblyMinorVersion.Text = fileVersionInfo.FileMinorPart.ToString();
                    assemblyBuildPart.Text = fileVersionInfo.FileBuildPart.ToString();
                    assemblyPrivatePart.Text = fileVersionInfo.FilePrivatePart.ToString();
                }
            }
        }
    }
}
