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

namespace yoSSTool
{
    public partial class SSTool : Form
    {
        public SSTool()
        {
            InitializeComponent();
        }
        

        private void ph2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "ProcessHacker.exe";
            Process.Start(sInfo);
        }

        private void luyten_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "luyten-0.5.4.exe";
            Process.Start(sInfo);
        }

        private void everything_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "Everything.exe";
            Process.Start(sInfo);
        }

        private void uav_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "UserAssistView.exe";
            Process.Start(sInfo);
        }

        private void lav_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "LastActivityView.exe";
            Process.Start(sInfo);
        }

        private void jdguiClick(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "jdgui.jar";
            Process.Start(sInfo);
        }

        private void procExpClick(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            sInfo.FileName = "procexp.exe";
            Process.Start(sInfo);
        }

        private void logDate(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
            string dt = dateTimePicker1.Value.ToString("hh:mm:ss tt dd/MM/yyyy");
            string path = @"C:\Temp\ScreenshareLog.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("This user has been screenshared before.");
                    sw.WriteLine("SS Date: " + dt);
                    sw.WriteLine(" ");
                }   
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("This user has been screenshared before.");
                    sw.WriteLine("SS Date: " + dt);
                    sw.WriteLine(" ");
                }
            }
        }

        private void openPrevLogClick(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Temp\ScreenshareLog.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    ProcessStartInfo sInfo = new ProcessStartInfo();
                    sInfo.WorkingDirectory = "C:/Temp";
                    sInfo.FileName = "ScreenshareLog.txt";
                    Process.Start(sInfo);
                }
            }
            catch (FileNotFoundException exception)
            {
                string message = "No Screenshare were found for this user.";
                string top = "Screenshare Logs";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, top, buttons, icon);
            }
        }
    }
}