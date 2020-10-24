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
            sInfo.WorkingDirectory = "C:/Users/chick/Desktop/Yochran's SS tools";
            sInfo.FileName = "ProcessHacker.exe";
            Process.Start(sInfo);
        }

        private void luyten_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = "C:/Users/chick/Desktop/Yochran's SS tools";
            sInfo.FileName = "luyten-0.5.4.exe";
            Process.Start(sInfo);
        }

        private void everything_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = "C:/Program Files/Everything";
            sInfo.FileName = "Everything.exe";
            Process.Start(sInfo);
        }

        private void uav_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = "C:/Users/chick/Desktop/Yochran's SS tools";
            sInfo.FileName = "UserAssistView.exe";
            Process.Start(sInfo);
        }

        private void lav_Click_1(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo();
            sInfo.WorkingDirectory = "C:/Users/chick/Desktop/Yochran's SS tools";
            sInfo.FileName = "LastActivityView.exe";
            Process.Start(sInfo);
        }
    }
}