
namespace Crypter
{
    partial class MainFrm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.payloadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filenameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.specialBox = new System.Windows.Forms.ComboBox();
            this.foldernameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.schtasksNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.regeditNameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.encryptionTypeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.runpeTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.sleepNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.sleepCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.assemblyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.buildBtn = new Guna.UI2.WinForms.Guna2Button();
            this.regeditCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.antiVM = new Guna.UI2.WinForms.Guna2CheckBox();
            this.schtasksChk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.browsePayloadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hiddenFile = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.background = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.filePumper = new Guna.UI2.WinForms.Guna2CheckBox();
            this.PumperStr = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sleepNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PumperStr)).BeginInit();
            this.SuspendLayout();
            // 
            // payloadTxt
            // 
            this.payloadTxt.BackColor = System.Drawing.Color.White;
            this.payloadTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payloadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.payloadTxt.ForeColor = System.Drawing.Color.Black;
            this.payloadTxt.Location = new System.Drawing.Point(45, 113);
            this.payloadTxt.Multiline = true;
            this.payloadTxt.Name = "payloadTxt";
            this.payloadTxt.Size = new System.Drawing.Size(282, 28);
            this.payloadTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payload:";
            // 
            // filenameTxt
            // 
            this.filenameTxt.BackColor = System.Drawing.Color.White;
            this.filenameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filenameTxt.Enabled = false;
            this.filenameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filenameTxt.ForeColor = System.Drawing.Color.Black;
            this.filenameTxt.Location = new System.Drawing.Point(45, 168);
            this.filenameTxt.Multiline = true;
            this.filenameTxt.Name = "filenameTxt";
            this.filenameTxt.Size = new System.Drawing.Size(282, 24);
            this.filenameTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "File name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Special Folder:";
            // 
            // specialBox
            // 
            this.specialBox.BackColor = System.Drawing.Color.White;
            this.specialBox.Enabled = false;
            this.specialBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specialBox.ForeColor = System.Drawing.Color.Black;
            this.specialBox.FormattingEnabled = true;
            this.specialBox.Location = new System.Drawing.Point(45, 219);
            this.specialBox.Name = "specialBox";
            this.specialBox.Size = new System.Drawing.Size(282, 24);
            this.specialBox.TabIndex = 13;
            // 
            // foldernameTxt
            // 
            this.foldernameTxt.BackColor = System.Drawing.Color.White;
            this.foldernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foldernameTxt.Enabled = false;
            this.foldernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.foldernameTxt.ForeColor = System.Drawing.Color.Black;
            this.foldernameTxt.Location = new System.Drawing.Point(45, 270);
            this.foldernameTxt.Multiline = true;
            this.foldernameTxt.Name = "foldernameTxt";
            this.foldernameTxt.Size = new System.Drawing.Size(282, 24);
            this.foldernameTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Folder name:";
            // 
            // schtasksNameTxt
            // 
            this.schtasksNameTxt.BackColor = System.Drawing.Color.White;
            this.schtasksNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schtasksNameTxt.Enabled = false;
            this.schtasksNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schtasksNameTxt.ForeColor = System.Drawing.Color.Black;
            this.schtasksNameTxt.Location = new System.Drawing.Point(45, 320);
            this.schtasksNameTxt.Multiline = true;
            this.schtasksNameTxt.Name = "schtasksNameTxt";
            this.schtasksNameTxt.Size = new System.Drawing.Size(282, 24);
            this.schtasksNameTxt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hidden Startup name:";
            // 
            // regeditNameTxt
            // 
            this.regeditNameTxt.BackColor = System.Drawing.Color.White;
            this.regeditNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regeditNameTxt.Enabled = false;
            this.regeditNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regeditNameTxt.ForeColor = System.Drawing.Color.Black;
            this.regeditNameTxt.Location = new System.Drawing.Point(45, 370);
            this.regeditNameTxt.Multiline = true;
            this.regeditNameTxt.Name = "regeditNameTxt";
            this.regeditNameTxt.Size = new System.Drawing.Size(282, 24);
            this.regeditNameTxt.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Startup name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(41, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Encryption Method:";
            // 
            // encryptionTypeBox
            // 
            this.encryptionTypeBox.BackColor = System.Drawing.Color.White;
            this.encryptionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptionTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptionTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptionTypeBox.ForeColor = System.Drawing.Color.Black;
            this.encryptionTypeBox.FormattingEnabled = true;
            this.encryptionTypeBox.Items.AddRange(new object[] {
            "AES",
            "XOR"});
            this.encryptionTypeBox.Location = new System.Drawing.Point(45, 421);
            this.encryptionTypeBox.Name = "encryptionTypeBox";
            this.encryptionTypeBox.Size = new System.Drawing.Size(282, 24);
            this.encryptionTypeBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(41, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Injection Method:";
            // 
            // runpeTypeBox
            // 
            this.runpeTypeBox.BackColor = System.Drawing.Color.White;
            this.runpeTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runpeTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runpeTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runpeTypeBox.ForeColor = System.Drawing.Color.Black;
            this.runpeTypeBox.FormattingEnabled = true;
            this.runpeTypeBox.Items.AddRange(new object[] {
            "RegAsm",
            "RegSvcs",
            "aspnet_compiler",
            "MSBuild",
            "Itself"});
            this.runpeTypeBox.Location = new System.Drawing.Point(45, 472);
            this.runpeTypeBox.Name = "runpeTypeBox";
            this.runpeTypeBox.Size = new System.Drawing.Size(282, 24);
            this.runpeTypeBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Encryptix Crypter";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // sleepNum
            // 
            this.sleepNum.BackColor = System.Drawing.Color.Transparent;
            this.sleepNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sleepNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sleepNum.Location = new System.Drawing.Point(348, 298);
            this.sleepNum.Name = "sleepNum";
            this.sleepNum.Size = new System.Drawing.Size(100, 24);
            this.sleepNum.TabIndex = 38;
            // 
            // sleepCheck
            // 
            this.sleepCheck.AutoSize = true;
            this.sleepCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sleepCheck.CheckedState.BorderRadius = 0;
            this.sleepCheck.CheckedState.BorderThickness = 0;
            this.sleepCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sleepCheck.ForeColor = System.Drawing.Color.White;
            this.sleepCheck.Location = new System.Drawing.Point(348, 274);
            this.sleepCheck.Name = "sleepCheck";
            this.sleepCheck.Size = new System.Drawing.Size(53, 17);
            this.sleepCheck.TabIndex = 39;
            this.sleepCheck.Text = "Delay";
            this.sleepCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sleepCheck.UncheckedState.BorderRadius = 0;
            this.sleepCheck.UncheckedState.BorderThickness = 0;
            this.sleepCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sleepCheck.CheckedChanged += new System.EventHandler(this.sleepCheck_CheckedChanged);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(422, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 42;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(467, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 40;
            // 
            // assemblyBtn
            // 
            this.assemblyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.assemblyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.assemblyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.assemblyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.assemblyBtn.FillColor = System.Drawing.Color.Transparent;
            this.assemblyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.assemblyBtn.ForeColor = System.Drawing.Color.White;
            this.assemblyBtn.HoverState.FillColor = System.Drawing.Color.Silver;
            this.assemblyBtn.Location = new System.Drawing.Point(348, 385);
            this.assemblyBtn.Name = "assemblyBtn";
            this.assemblyBtn.Size = new System.Drawing.Size(116, 28);
            this.assemblyBtn.TabIndex = 43;
            this.assemblyBtn.Text = "Clone Assembly";
            this.assemblyBtn.Click += new System.EventHandler(this.assemblyBtn_Click_1);
            // 
            // buildBtn
            // 
            this.buildBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buildBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buildBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buildBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buildBtn.FillColor = System.Drawing.Color.Transparent;
            this.buildBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buildBtn.ForeColor = System.Drawing.Color.White;
            this.buildBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.buildBtn.Location = new System.Drawing.Point(348, 419);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(116, 28);
            this.buildBtn.TabIndex = 44;
            this.buildBtn.Text = "Crypt";
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click_1);
            // 
            // regeditCheck
            // 
            this.regeditCheck.AutoSize = true;
            this.regeditCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regeditCheck.CheckedState.BorderRadius = 0;
            this.regeditCheck.CheckedState.BorderThickness = 0;
            this.regeditCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regeditCheck.ForeColor = System.Drawing.Color.White;
            this.regeditCheck.Location = new System.Drawing.Point(348, 162);
            this.regeditCheck.Name = "regeditCheck";
            this.regeditCheck.Size = new System.Drawing.Size(60, 17);
            this.regeditCheck.TabIndex = 47;
            this.regeditCheck.Text = "Startup";
            this.regeditCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.regeditCheck.UncheckedState.BorderRadius = 0;
            this.regeditCheck.UncheckedState.BorderThickness = 0;
            this.regeditCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.regeditCheck.CheckedChanged += new System.EventHandler(this.regeditCheck_CheckedChanged);
            // 
            // antiVM
            // 
            this.antiVM.AutoSize = true;
            this.antiVM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.antiVM.CheckedState.BorderRadius = 0;
            this.antiVM.CheckedState.BorderThickness = 0;
            this.antiVM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.antiVM.ForeColor = System.Drawing.Color.White;
            this.antiVM.Location = new System.Drawing.Point(348, 251);
            this.antiVM.Name = "antiVM";
            this.antiVM.Size = new System.Drawing.Size(60, 17);
            this.antiVM.TabIndex = 45;
            this.antiVM.Text = "AntiVM";
            this.antiVM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.antiVM.UncheckedState.BorderRadius = 0;
            this.antiVM.UncheckedState.BorderThickness = 0;
            this.antiVM.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // schtasksChk
            // 
            this.schtasksChk.AutoSize = true;
            this.schtasksChk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.schtasksChk.CheckedState.BorderRadius = 0;
            this.schtasksChk.CheckedState.BorderThickness = 0;
            this.schtasksChk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.schtasksChk.ForeColor = System.Drawing.Color.White;
            this.schtasksChk.Location = new System.Drawing.Point(348, 185);
            this.schtasksChk.Name = "schtasksChk";
            this.schtasksChk.Size = new System.Drawing.Size(97, 17);
            this.schtasksChk.TabIndex = 48;
            this.schtasksChk.Text = "Hidden Startup";
            this.schtasksChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.schtasksChk.UncheckedState.BorderRadius = 0;
            this.schtasksChk.UncheckedState.BorderThickness = 0;
            this.schtasksChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.schtasksChk.CheckedChanged += new System.EventHandler(this.schtasksChk_CheckedChanged);
            // 
            // browsePayloadBtn
            // 
            this.browsePayloadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.browsePayloadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.browsePayloadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.browsePayloadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.browsePayloadBtn.FillColor = System.Drawing.Color.Transparent;
            this.browsePayloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.browsePayloadBtn.ForeColor = System.Drawing.Color.White;
            this.browsePayloadBtn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.browsePayloadBtn.Location = new System.Drawing.Point(348, 113);
            this.browsePayloadBtn.Name = "browsePayloadBtn";
            this.browsePayloadBtn.Size = new System.Drawing.Size(75, 28);
            this.browsePayloadBtn.TabIndex = 49;
            this.browsePayloadBtn.Text = "Browse";
            this.browsePayloadBtn.Click += new System.EventHandler(this.browsePayloadBtn_Click_1);
            // 
            // hiddenFile
            // 
            this.hiddenFile.AutoSize = true;
            this.hiddenFile.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hiddenFile.CheckedState.BorderRadius = 0;
            this.hiddenFile.CheckedState.BorderThickness = 0;
            this.hiddenFile.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hiddenFile.ForeColor = System.Drawing.Color.White;
            this.hiddenFile.Location = new System.Drawing.Point(348, 208);
            this.hiddenFile.Name = "hiddenFile";
            this.hiddenFile.Size = new System.Drawing.Size(76, 17);
            this.hiddenFile.TabIndex = 50;
            this.hiddenFile.Text = "HiddenFile";
            this.hiddenFile.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hiddenFile.UncheckedState.BorderRadius = 0;
            this.hiddenFile.UncheckedState.BorderThickness = 0;
            this.hiddenFile.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox2.Location = new System.Drawing.Point(348, 229);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(80, 17);
            this.guna2CheckBox2.TabIndex = 51;
            this.guna2CheckBox2.Text = "AntiCRACK";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.ImageRotate = 0F;
            this.background.Location = new System.Drawing.Point(-18, -15);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(561, 614);
            this.background.TabIndex = 52;
            this.background.TabStop = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.background;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // filePumper
            // 
            this.filePumper.AutoSize = true;
            this.filePumper.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filePumper.CheckedState.BorderRadius = 0;
            this.filePumper.CheckedState.BorderThickness = 0;
            this.filePumper.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filePumper.ForeColor = System.Drawing.Color.White;
            this.filePumper.Location = new System.Drawing.Point(348, 328);
            this.filePumper.Name = "filePumper";
            this.filePumper.Size = new System.Drawing.Size(81, 17);
            this.filePumper.TabIndex = 53;
            this.filePumper.Text = "File Pumper";
            this.filePumper.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filePumper.UncheckedState.BorderRadius = 0;
            this.filePumper.UncheckedState.BorderThickness = 0;
            this.filePumper.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.filePumper.CheckedChanged += new System.EventHandler(this.filePumper_CheckedChanged);
            // 
            // PumperStr
            // 
            this.PumperStr.BackColor = System.Drawing.Color.Transparent;
            this.PumperStr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PumperStr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PumperStr.Location = new System.Drawing.Point(348, 351);
            this.PumperStr.Name = "PumperStr";
            this.PumperStr.Size = new System.Drawing.Size(100, 24);
            this.PumperStr.TabIndex = 54;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 573);
            this.Controls.Add(this.PumperStr);
            this.Controls.Add(this.filePumper);
            this.Controls.Add(this.guna2CheckBox2);
            this.Controls.Add(this.hiddenFile);
            this.Controls.Add(this.browsePayloadBtn);
            this.Controls.Add(this.schtasksChk);
            this.Controls.Add(this.regeditCheck);
            this.Controls.Add(this.antiVM);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.assemblyBtn);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.sleepCheck);
            this.Controls.Add(this.sleepNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.payloadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filenameTxt);
            this.Controls.Add(this.runpeTypeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.specialBox);
            this.Controls.Add(this.encryptionTypeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.foldernameTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.schtasksNameTxt);
            this.Controls.Add(this.regeditNameTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypter";
            ((System.ComponentModel.ISupportInitialize)(this.sleepNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PumperStr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox payloadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filenameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox specialBox;
        private System.Windows.Forms.TextBox foldernameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox schtasksNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox regeditNameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox encryptionTypeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox runpeTypeBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2NumericUpDown sleepNum;
        private Guna.UI2.WinForms.Guna2CheckBox sleepCheck;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button buildBtn;
        private Guna.UI2.WinForms.Guna2Button assemblyBtn;
        private Guna.UI2.WinForms.Guna2CheckBox regeditCheck;
        private Guna.UI2.WinForms.Guna2CheckBox antiVM;
        private Guna.UI2.WinForms.Guna2CheckBox schtasksChk;
        private Guna.UI2.WinForms.Guna2Button browsePayloadBtn;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox hiddenFile;
        private Guna.UI2.WinForms.Guna2PictureBox background;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2CheckBox filePumper;
        private Guna.UI2.WinForms.Guna2NumericUpDown PumperStr;
    }
}

