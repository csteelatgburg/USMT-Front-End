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
            DirectoryInfo di = new DirectoryInfo(StoreLocation.SelectedPath + "\\USMT");

            if (di.Exists)
            {
                LoadProfile.Checked = true;
                string CommandString = @"loadstate " + StoreLocation.SelectedPath + @" /i:miguser.xml /i:migapp.xml";
                Command.Text = CommandString;
                Directions.Text = "You have chosen a folder which contains a profile.\r\n" +
                    "This tool will restore the contained profile to this computer.\r\n\r\n" +
                    "Step 2: Click Execute to run the loadstate command";


            }
            else
            {
                StoreProfile.Checked = true;
                string UserProfile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if(UserProfile.Contains(@"C:\Documents and Settings")) {
                    ProfilesDirectory = "c:\\documents and settings";
                }
                else if (UserProfile.Contains(@"C:\Users")) {
                    ProfilesDirectory = "C:\\Users";
                }
                DirectoryInfo ProfilesDir = new DirectoryInfo(ProfilesDirectory);
                DirectoryInfo[] Profiles = ProfilesDir.GetDirectories();
                foreach (DirectoryInfo dir in Profiles)
                {
                    Users.Items.Add(dir.Name);
                }
                Users.Refresh();
                Directions.Text = "You have selected a directory that does not contain a \r\n USMT folder with data inside. \r\n\r\n" +
                    "Step 2: Select the user to migrate from the list on the left";
             

            }

            StoreFolderTextBox.Text = StoreLocation.SelectedPath;
          
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string commandstring = USMTFolder.SelectedPath + "\\" + "scanstate.exe " + StoreLocation.SelectedPath + @" /ue:*\* /ui:fas\" + Users.SelectedItem + @" /i:miguser.xml /i:migapp.xml  /o /v:1";
            Command.Text =  commandstring;
            Directions.Text = "Step 3: Click Execute to store the user's profile";

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
                process.StartInfo.Arguments = StoreLocation.SelectedPath + @" /ue:*\* /ui:" + Domain.Text.ToString() + @"\" + Users.SelectedItem + @" /i:miguser.xml /i:migapp.xml  /o /v:1";
                //process.Start();

            }
            else if (LoadProfile.Checked == true)
            {
                process.Exited += new EventHandler(loadstate_Exited);
                process.StartInfo.WorkingDirectory = USMTFolder.SelectedPath;
                process.StartInfo.FileName = "loadstate";
                process.StartInfo.Arguments = StoreLocation.SelectedPath + @" /i:miguser.xml /i:migapp.xml";
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

        }

        private void SetUSMTLocation_Click(object sender, EventArgs e)
        {
            USMTFolder.SelectedPath = Directory.GetCurrentDirectory();
            USMTFolder.ShowDialog();
            USMTFolderPath.Text = USMTFolder.SelectedPath;
            
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

    }
}
