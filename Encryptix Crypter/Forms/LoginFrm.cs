using KeyAuth;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Crypter.Forms
{
    public partial class loginFrm : Form
    {

        public static api KeyAuthApp = new api(
            name: "World",
            ownerid: "3srXNUCGte",
            secret: "3758243aa93bda14ff786869bd495a712611b7af6b3fd843c6a98511d578bb05",
            version: "1.0"
        );

        private Timer opacityTimer;
        private double targetOpacity = 1.0;
        private const double opacityIncrement = 0.05;


        public loginFrm()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();


            opacityTimer = new Timer();
            opacityTimer.Interval = 50;
            opacityTimer.Tick += OpacityTimer1_Tick;
            opacityTimer.Start();

            this.Opacity = 0;


            string savedUsername = GetSavedUsernameFromRegistry();
            string savedPassword = GetSavedPasswordFromRegistry();
            if (!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(savedPassword))
            {
                username.Text = savedUsername;
                password.Text = savedPassword;
            }
        }

        private string GetSavedUsernameFromRegistry()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Encryptix"))
            {
                if (key != null)
                {
                    return key.GetValue("Username") as string;
                }
            }
            return null;
        }

        private void SaveCredentialsToRegistry(string username, string password)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Encryptix"))
            {
                if (key != null)
                {
                    key.SetValue("Username", username);
                    key.SetValue("Password", password);
                }
            }
        }

        private string GetSavedPasswordFromRegistry()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Encryptix"))
            {
                if (key != null)
                {
                    return key.GetValue("Password") as string;
                }
            }
            return null;
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);


            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Environment.Exit(0);
            }

            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                SaveCredentialsToRegistry(username.Text, password.Text);
                this.Hide();
            MainFrm main = new MainFrm();
            main.Show();
            }
            else
                status.Text = "Status: " + KeyAuthApp.response.message;
        }

        private void frgtPswrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("encryptix", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpacityTimer1_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                opacityTimer.Stop();
                return;
            }

            if (this.Opacity < targetOpacity)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                opacityTimer.Stop();
            }
        }

    }
}
