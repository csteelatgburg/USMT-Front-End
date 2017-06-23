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
            this.Directions = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Folder";
            // 
            // StoreFolderTextBox
            // 
            this.StoreFolderTextBox.Location = new System.Drawing.Point(172, 23);
            this.StoreFolderTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StoreFolderTextBox.Name = "StoreFolderTextBox";
            this.StoreFolderTextBox.Size = new System.Drawing.Size(614, 31);
            this.StoreFolderTextBox.TabIndex = 1;
            // 
            // SetStoreFolder
            // 
            this.SetStoreFolder.Location = new System.Drawing.Point(798, 20);
            this.SetStoreFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.StoreProfile.Location = new System.Drawing.Point(24, 73);
            this.StoreProfile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StoreProfile.Name = "StoreProfile";
            this.StoreProfile.Size = new System.Drawing.Size(161, 29);
            this.StoreProfile.TabIndex = 3;
            this.StoreProfile.TabStop = true;
            this.StoreProfile.Text = "Store Profile";
            this.StoreProfile.UseVisualStyleBackColor = true;
            // 
            // LoadProfile
            // 
            this.LoadProfile.AutoSize = true;
            this.LoadProfile.Location = new System.Drawing.Point(200, 73);
            this.LoadProfile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadProfile.Name = "LoadProfile";
            this.LoadProfile.Size = new System.Drawing.Size(158, 29);
            this.LoadProfile.TabIndex = 4;
            this.LoadProfile.TabStop = true;
            this.LoadProfile.Text = "Load Profile";
            this.LoadProfile.UseVisualStyleBackColor = true;
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Location = new System.Drawing.Point(15, 729);
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
            this.Users.Location = new System.Drawing.Point(25, 114);
            this.Users.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(334, 254);
            this.Users.TabIndex = 6;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // Directions
            // 
            this.Directions.AutoSize = true;
            this.Directions.Location = new System.Drawing.Point(532, 85);
            this.Directions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(535, 25);
            this.Directions.TabIndex = 7;
            this.Directions.Text = "Step 1. Click the Set button to browse for a store folder";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(788, 373);
            this.Execute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.ProfileSize.Location = new System.Drawing.Point(398, 129);
            this.ProfileSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProfileSize.Name = "ProfileSize";
            this.ProfileSize.Size = new System.Drawing.Size(18, 25);
            this.ProfileSize.TabIndex = 9;
            this.ProfileSize.Text = " ";
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(12, 766);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(1229, 31);
            this.Command.TabIndex = 10;
            // 
            // USMTFolderPath
            // 
            this.USMTFolderPath.Location = new System.Drawing.Point(191, 509);
            this.USMTFolderPath.Name = "USMTFolderPath";
            this.USMTFolderPath.Size = new System.Drawing.Size(516, 31);
            this.USMTFolderPath.TabIndex = 11;
            // 
            // USMTFolderLabel
            // 
            this.USMTFolderLabel.AutoSize = true;
            this.USMTFolderLabel.Location = new System.Drawing.Point(25, 509);
            this.USMTFolderLabel.Name = "USMTFolderLabel";
            this.USMTFolderLabel.Size = new System.Drawing.Size(160, 25);
            this.USMTFolderLabel.TabIndex = 12;
            this.USMTFolderLabel.Text = "USMT Location";
            // 
            // SetUSMTLocation
            // 
            this.SetUSMTLocation.Location = new System.Drawing.Point(713, 509);
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
            this.DomainLabel.Location = new System.Drawing.Point(25, 646);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(85, 25);
            this.DomainLabel.TabIndex = 14;
            this.DomainLabel.Text = "Domain";
            // 
            // Domain
            // 
            this.Domain.Location = new System.Drawing.Point(128, 646);
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(100, 31);
            this.Domain.TabIndex = 15;
            this.Domain.Text = "fas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(234, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(819, 79);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter the domain name for the user to be transferred, this will be appended to th" +
    "e user selected above.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(786, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select the folder that contains the USMT files (scanstate.exe, loadstate.exe, etc" +
    ".)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 809);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Domain);
            this.Controls.Add(this.DomainLabel);
            this.Controls.Add(this.SetUSMTLocation);
            this.Controls.Add(this.USMTFolderLabel);
            this.Controls.Add(this.USMTFolderPath);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.ProfileSize);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.LoadProfile);
            this.Controls.Add(this.StoreProfile);
            this.Controls.Add(this.SetStoreFolder);
            this.Controls.Add(this.StoreFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label Directions;
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
        private System.Windows.Forms.Label label3;
    }
}

