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
            this.Command = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.ListBox();
            this.Directions = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.ProfileSize = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Folder";
            // 
            // StoreFolderTextBox
            // 
            this.StoreFolderTextBox.Location = new System.Drawing.Point(86, 12);
            this.StoreFolderTextBox.Name = "StoreFolderTextBox";
            this.StoreFolderTextBox.Size = new System.Drawing.Size(309, 20);
            this.StoreFolderTextBox.TabIndex = 1;
            // 
            // SetStoreFolder
            // 
            this.SetStoreFolder.Location = new System.Drawing.Point(418, 13);
            this.SetStoreFolder.Name = "SetStoreFolder";
            this.SetStoreFolder.Size = new System.Drawing.Size(78, 19);
            this.SetStoreFolder.TabIndex = 2;
            this.SetStoreFolder.Text = "Set";
            this.SetStoreFolder.UseVisualStyleBackColor = true;
            this.SetStoreFolder.Click += new System.EventHandler(this.SetStoreFolder_Click);
            // 
            // StoreProfile
            // 
            this.StoreProfile.AutoSize = true;
            this.StoreProfile.Location = new System.Drawing.Point(12, 38);
            this.StoreProfile.Name = "StoreProfile";
            this.StoreProfile.Size = new System.Drawing.Size(82, 17);
            this.StoreProfile.TabIndex = 3;
            this.StoreProfile.TabStop = true;
            this.StoreProfile.Text = "Store Profile";
            this.StoreProfile.UseVisualStyleBackColor = true;
            // 
            // LoadProfile
            // 
            this.LoadProfile.AutoSize = true;
            this.LoadProfile.Location = new System.Drawing.Point(100, 38);
            this.LoadProfile.Name = "LoadProfile";
            this.LoadProfile.Size = new System.Drawing.Size(81, 17);
            this.LoadProfile.TabIndex = 4;
            this.LoadProfile.TabStop = true;
            this.LoadProfile.Text = "Load Profile";
            this.LoadProfile.UseVisualStyleBackColor = true;
            // 
            // Command
            // 
            this.Command.AutoSize = true;
            this.Command.Location = new System.Drawing.Point(16, 210);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(0, 13);
            this.Command.TabIndex = 5;
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.Location = new System.Drawing.Point(12, 61);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(169, 134);
            this.Users.TabIndex = 6;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            // 
            // Directions
            // 
            this.Directions.AutoSize = true;
            this.Directions.Location = new System.Drawing.Point(266, 44);
            this.Directions.Name = "Directions";
            this.Directions.Size = new System.Drawing.Size(265, 13);
            this.Directions.TabIndex = 7;
            this.Directions.Text = "Step 1. Click the Set button to browse for a store folder";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(481, 203);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(83, 27);
            this.Execute.TabIndex = 8;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // ProfileSize
            // 
            this.ProfileSize.AutoSize = true;
            this.ProfileSize.Location = new System.Drawing.Point(199, 67);
            this.ProfileSize.Name = "ProfileSize";
            this.ProfileSize.Size = new System.Drawing.Size(10, 13);
            this.ProfileSize.TabIndex = 9;
            this.ProfileSize.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 244);
            this.Controls.Add(this.ProfileSize);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Directions);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.LoadProfile);
            this.Controls.Add(this.StoreProfile);
            this.Controls.Add(this.SetStoreFolder);
            this.Controls.Add(this.StoreFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users);
            this.Name = "Form1";
            this.Text = "USMT";
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
        private System.Windows.Forms.Label Command;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.Label Directions;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label ProfileSize;
    }
}

