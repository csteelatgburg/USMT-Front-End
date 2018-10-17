using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string ProfilesDirectory = "";
        public static long DirSize(DirectoryInfo d)
        {
            long Size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                Size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                Size += DirSize(di);
            }
            return (Size);
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void SetStoreFolder_Click(object sender, EventArgs e)
        {
            StoreLocation.ShowDialog();
            if(StoreProfile.Checked == true)
            {
                FileInfo di = new FileInfo(StoreLocation.SelectedPath + "\\USMT.MIG");
                if (di.Exists)
                {
                    MessageBox.Show("This folder already contains a USMT.MIG store and it will be replaced.");
                }
                    string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (UserProfile.Contains(@"C:\Documents and Settings"))
                {
                    ProfilesDirectory = "c:\\documents and settings";
                }
                else if (UserProfile.Contains(@"C:\Users"))
                {
                    ProfilesDirectory = "C:\\Users";
                }
                DirectoryInfo ProfilesDir = new DirectoryInfo(ProfilesDirectory);
                DirectoryInfo[] Profiles = ProfilesDir.GetDirectories();
                foreach (DirectoryInfo dir in Profiles)
                {
                    Users.Items.Add(dir.Name);
                }
                Users.Refresh();

                StoreFolderTextBox.Text = StoreLocation.SelectedPath;

                string commandstring = USMTFolder.SelectedPath + "\\" + "scanstate.exe " + StoreLocation.SelectedPath;
                Command.Text = commandstring;
                UsersLabel.Visible = true;
                Users.Visible = true;
                Step4Label.Text = "Step 4. Select the users to migrate.";
                Step4Label.Visible = true;

            }
            else if (LoadProfile.Checked == true)
            {
                FileInfo di = new FileInfo(StoreLocation.SelectedPath + "\\USMT.MIG");
                if (di.Exists)
                {
                    StoreFolderTextBox.Text = StoreLocation.SelectedPath;
                    Step4Label.Text = "Step 4. Click the Execute button to run the loadstate command.";
                    StoreLocation.SelectedPath = StoreLocation.SelectedPath.Replace("\\USMT", "");
                    string commandstring = USMTFolder.SelectedPath + "\\" + "loadstate.exe " + StoreLocation.SelectedPath + @" /i:miguser.xml /i:migapp.xml";
                    Command.Text = commandstring;
                    Execute.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The selected folder does not contain the USMT folder and USMT.MIG file.");
                }

            } 

        }          

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usersString = "";
            
            foreach(var user in Users.SelectedItems ) 
                {
                
                //MessageBox.Show(user.ToString());
                usersString += @" /ui:" + Domain.Text + @"\" + user.ToString();
                } 
            string commandstring = USMTFolder.SelectedPath + "\\" + "scanstate.exe " + StoreLocation.SelectedPath + @" /ue:*\* " + usersString + @" /i:miguser.xml /i:migapp.xml  /o /v:1";
            Command.Text =  commandstring;
            Step5Label.Visible = true;
            Execute.Enabled = true;

        }

        private void Execute_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(Directory.GetCurrentDirectory());
            //System.Diagnostics.Process.Start( Command.Text);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.EnableRaisingEvents = true;
            //process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            if (StoreProfile.Checked == true)
            {
                process.Exited += new EventHandler(scanstate_Exited);
                process.StartInfo.WorkingDirectory = USMTFolder.SelectedPath;
                process.StartInfo.FileName = "scanstate.exe";
                string usersString = "";
                foreach (var user in Users.SelectedItems)
                {
                    usersString += @" /ui:" + Domain.Text + @"\" + user.ToString();
                }

                process.StartInfo.Arguments = StoreLocation.SelectedPath + @" /ue:*\* " + usersString + @" /i:miguser.xml /i:migapp.xml  /o /v:1 " + addCLM.Text;
                //process.Start();

            }
            else if (LoadProfile.Checked == true)
            {
                process.Exited += new EventHandler(loadstate_Exited);
                process.StartInfo.WorkingDirectory = USMTFolder.SelectedPath;
                process.StartInfo.FileName = "loadstate";
                process.StartInfo.Arguments = StoreLocation.SelectedPath + @" /i:miguser.xml /i:migapp.xml " + addCLM.Text;
                //process.Start();
            } else
            {
                MessageBox.Show("Please don't click this button, yet.");
            }
            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message + "\n" + "Is this application in the same folder as the USMT files or did you set the USMT Folder location?");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            USMTFolder.SelectedPath = Directory.GetCurrentDirectory();
            FileInfo di = new FileInfo(USMTFolder.SelectedPath + "\\scanstate.exe ");

            if (di.Exists)
            {
                USMTFolderPath.Text = USMTFolder.SelectedPath;
                StoreProfile.Enabled = true;
                LoadProfile.Enabled = true;
            }
        }

        private void SetUSMTLocation_Click(object sender, EventArgs e)
        {
            USMTFolder.SelectedPath = Directory.GetCurrentDirectory();
            USMTFolder.ShowDialog();
            FileInfo di = new FileInfo(USMTFolder.SelectedPath + "\\scanstate.exe ");
            

            if (di.Exists)
            {
                USMTFolderPath.Text = USMTFolder.SelectedPath;
                StoreProfile.Enabled = true;
                LoadProfile.Enabled = true;
            } else
            {
                MessageBox.Show("The selected folder does not contain the USMT tools.");
            }
            
            Command.Text = USMTFolder.SelectedPath + "\\";

        }

        private void scanstate_Exited(object sender, System.EventArgs e)
        {
            MessageBox.Show("Scanstate completed.");
            System.Diagnostics.Process.Start(USMTFolder.SelectedPath + "\\scanstate.log");

        }

        private void loadstate_Exited(object sender, System.EventArgs e)
        {
            MessageBox.Show("Loadstate completed.");
            System.Diagnostics.Process.Start(USMTFolder.SelectedPath + "\\loadstate.log");

        }

        private void StoreProfile_CheckedChanged(object sender, EventArgs e)
        {
            SetStoreFolder.Enabled = true;
            Step3Label.Text = "Step 3. Set the folder to save the profile.";
            Command.Text = USMTFolder.SelectedPath + "\\scanstate.exe ";
        }

        private void LoadProfile_CheckedChanged(object sender, EventArgs e)
        {
            SetStoreFolder.Enabled = true;
            Step3Label.Text = "Step 3. Set the folder to the location of the USMT.MIG.";
            Command.Text = USMTFolder.SelectedPath + "\\loadstate.exe ";
        }

        private void addCLM_TextChanged(object sender, EventArgs e)
        {
            //Command.Text += addCLM.Text;
        }
    }
}
