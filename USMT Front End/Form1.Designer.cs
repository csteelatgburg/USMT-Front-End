namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.StoreLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreFolderTextBox = new System.Windows.Forms.TextBox();
            this.SetStoreFolder = new System.Windows.Forms.Button();
            this.StoreProfile = new System.Windows.Forms.RadioButton();
            this.LoadProfile = new System.Windows.Forms.RadioButton();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.ListBox();
            this.Step3Label = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.ProfileSize = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.TextBox();
            this.USMTFolderPath = new System.Windows.Forms.TextBox();
            this.USMTFolderLabel = new System.Windows.Forms.Label();
            this.SetUSMTLocation = new System.Windows.Forms.Button();
            this.USMTFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.Domain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Step1Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Step2Label = new System.Windows.Forms.Label();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.Step4Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Step5Label = new System.Windows.Forms.Label();
            this.addCLM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoreLocation
            // 
            this.StoreLocation.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.StoreLocation.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Folder";
            // 
            // StoreFolderTextBox
            // 
            this.StoreFolderTextBox.Location = new System.Drawing.Point(157, 256);
            this.StoreFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.StoreFolderTextBox.Name = "StoreFolderTextBox";
            this.StoreFolderTextBox.Size = new System.Drawing.Size(614, 31);
            this.StoreFolderTextBox.TabIndex = 1;
            // 
            // SetStoreFolder
            // 
            this.SetStoreFolder.Enabled = false;
            this.SetStoreFolder.Location = new System.Drawing.Point(783, 253);
            this.SetStoreFolder.Margin = new System.Windows.Forms.Padding(6);
            this.SetStoreFolder.Name = "SetStoreFolder";
            this.SetStoreFolder.Size = new System.Drawing.Size(156, 37);
            this.SetStoreFolder.TabIndex = 2;
            this.SetStoreFolder.Text = "Set";
            this.SetStoreFolder.UseVisualStyleBackColor = true;
            this.SetStoreFolder.Click += new System.EventHandler(this.SetStoreFolder_Click);
            // 
            // StoreProfile
            // 
            this.StoreProfile.AutoSize = true;
            this.StoreProfile.Enabled = false;
            this.StoreProfile.Location = new System.Drawing.Point(30, 149);
            this.StoreProfile.Margin = new System.Windows.Forms.Padding(6);
            this.StoreProfile.Name = "StoreProfile";
            this.StoreProfile.Size = new System.Drawing.Size(161, 29);
            this.StoreProfile.TabIndex = 3;
            this.StoreProfile.TabStop = true;
            this.StoreProfile.Text = "Store Profile";
            this.StoreProfile.UseVisualStyleBackColor = true;
            this.StoreProfile.CheckedChanged += new System.EventHandler(this.StoreProfile_CheckedChanged);
            // 
            // LoadProfile
            // 
            this.LoadProfile.AutoSize = true;
            this.LoadProfile.Enabled = false;
            this.LoadProfile.Location = new System.Drawing.Point(228, 149);
            this.LoadProfile.Margin = new System.Windows.Forms.Padding(6);
            this.LoadProfile.Name = "LoadProfile";
            this.LoadProfile.Size = new System.Drawing.Size(158, 29);
            this.LoadProfile.TabIndex = 4;
            this.LoadProfile.TabStop = true;
            this.LoadProfile.Text = "Load Profile";
            this.LoadProfile.UseVisualStyleBackColor = true;
            this.LoadProfile.CheckedChanged += new System.EventHandler(this.LoadProfile_CheckedChanged);
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Location = new System.Drawing.Point(15, 749);
            this.CommandLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(156, 25);
            this.CommandLabel.TabIndex = 5;
            this.CommandLabel.Text = "Command Line";
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 25;
            this.Users.Location = new System.Drawing.Point(157, 339);
            this.Users.Margin = new System.Windows.Forms.Padding(6);
            this.Users.Name = "Users";
            this.Users.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Users.Size = new System.Drawing.Size(334, 254);
            this.Users.TabIndex = 6;
            this.Users.Visible = false;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Location = new System.Drawing.Point(718, 296);
            this.Step3Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(80, 25);
            this.Step3Label.TabIndex = 7;
            this.Step3Label.Text = "Step 3.";
            // 
            // Execute
            // 
            this.Execute.Enabled = false;
            this.Execute.Location = new System.Drawing.Point(718, 407);
            this.Execute.Margin = new System.Windows.Forms.Padding(6);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(166, 52);
            this.Execute.TabIndex = 8;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // ProfileSize
            // 
            this.ProfileSize.AutoSize = true;
            this.ProfileSize.Location = new System.Drawing.Point(398, 149);
            this.ProfileSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProfileSize.Name = "ProfileSize";
            this.ProfileSize.Size = new System.Drawing.Size(18, 25);
            this.ProfileSize.TabIndex = 9;
            this.ProfileSize.Text = " ";
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(12, 786);
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            this.Command.Size = new System.Drawing.Size(1483, 31);
            this.Command.TabIndex = 10;
            // 
            // USMTFolderPath
            // 
            this.USMTFolderPath.Location = new System.Drawing.Point(191, 12);
            this.USMTFolderPath.Name = "USMTFolderPath";
            this.USMTFolderPath.Size = new System.Drawing.Size(516, 31);
            this.USMTFolderPath.TabIndex = 11;
            // 
            // USMTFolderLabel
            // 
            this.USMTFolderLabel.AutoSize = true;
            this.USMTFolderLabel.Location = new System.Drawing.Point(25, 9);
            this.USMTFolderLabel.Name = "USMTFolderLabel";
            this.USMTFolderLabel.Size = new System.Drawing.Size(160, 25);
            this.USMTFolderLabel.TabIndex = 12;
            this.USMTFolderLabel.Text = "USMT Location";
            // 
            // SetUSMTLocation
            // 
            this.SetUSMTLocation.Location = new System.Drawing.Point(713, 12);
            this.SetUSMTLocation.Name = "SetUSMTLocation";
            this.SetUSMTLocation.Size = new System.Drawing.Size(241, 36);
            this.SetUSMTLocation.TabIndex = 13;
            this.SetUSMTLocation.Text = "Set USMT Location";
            this.SetUSMTLocation.UseVisualStyleBackColor = true;
            this.SetUSMTLocation.Click += new System.EventHandler(this.SetUSMTLocation_Click);
            // 
            // USMTFolder
            // 
            this.USMTFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.USMTFolder.ShowNewFolderButton = false;
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Location = new System.Drawing.Point(25, 666);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(85, 25);
            this.DomainLabel.TabIndex = 14;
            this.DomainLabel.Text = "Domain";
            // 
            // Domain
            // 
            this.Domain.Location = new System.Drawing.Point(128, 666);
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(100, 31);
            this.Domain.TabIndex = 15;
            this.Domain.Text = "fas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(234, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(819, 79);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter the domain name for the user to be transferred, this will be appended to th" +
    "e user selected above when storing profiles.";
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Location = new System.Drawing.Point(713, 55);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(413, 25);
            this.Step1Label.TabIndex = 18;
            this.Step1Label.Text = "Step 1. Set the location of the USMT tools";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Defaults to application\'s folder";
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Location = new System.Drawing.Point(713, 148);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(533, 25);
            this.Step2Label.TabIndex = 20;
            this.Step2Label.Text = "Step 2. Do you want to store a profile or load a profile?";
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(25, 339);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(68, 25);
            this.UsersLabel.TabIndex = 21;
            this.UsersLabel.Text = "Users";
            this.UsersLabel.Visible = false;
            // 
            // Step4Label
            // 
            this.Step4Label.AutoSize = true;
            this.Step4Label.Location = new System.Drawing.Point(718, 339);
            this.Step4Label.Name = "Step4Label";
            this.Step4Label.Size = new System.Drawing.Size(0, 25);
            this.Step4Label.TabIndex = 22;
            this.Step4Label.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Settings";
            // 
            // Step5Label
            // 
            this.Step5Label.AutoSize = true;
            this.Step5Label.Location = new System.Drawing.Point(718, 469);
            this.Step5Label.Name = "Step5Label";
            this.Step5Label.Size = new System.Drawing.Size(461, 25);
            this.Step5Label.TabIndex = 24;
            this.Step5Label.Text = "Step 5. Click Execute to store the user profiles.";
            this.Step5Label.Visible = false;
            // 
            // addCLM
            // 
            this.addCLM.Location = new System.Drawing.Point(20, 873);
            this.addCLM.Name = "addCLM";
            this.addCLM.Size = new System.Drawing.Size(778, 31);
            this.addCLM.TabIndex = 25;
            this.addCLM.TextChanged += new System.EventHandler(this.addCLM_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 836);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Additional Command Line Arguments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 836);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "(will not be reflected above)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 950);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addCLM);
            this.Controls.Add(this.Step5Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Step4Label);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Step1Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Domain);
            this.Controls.Add(this.DomainLabel);
            this.Controls.Add(this.SetUSMTLocation);
            this.Controls.Add(this.USMTFolderLabel);
            this.Controls.Add(this.USMTFolderPath);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.ProfileSize);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Step3Label);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.LoadProfile);
            this.Controls.Add(this.StoreProfile);
            this.Controls.Add(this.SetStoreFolder);
            this.Controls.Add(this.StoreFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "USMT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog StoreLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StoreFolderTextBox;
        private System.Windows.Forms.Button SetStoreFolder;
        private System.Windows.Forms.RadioButton StoreProfile;
        private System.Windows.Forms.RadioButton LoadProfile;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label ProfileSize;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.TextBox USMTFolderPath;
        private System.Windows.Forms.Label USMTFolderLabel;
        private System.Windows.Forms.Button SetUSMTLocation;
        private System.Windows.Forms.FolderBrowserDialog USMTFolder;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.TextBox Domain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.Label Step4Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Step5Label;
        private System.Windows.Forms.TextBox addCLM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

