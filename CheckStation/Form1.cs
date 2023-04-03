using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using Managed.Adb;

namespace CheckStation
{
    public partial class Form1 : Form
    {
        Process adb = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDevManager_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void sharedLogs_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "");
        }

        private void sharedQolsys_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "");
        }

        private void checkIP_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = "ipconfig.exe";
                //p.StartInfo.Arguments = "/K adb devices";
                p.Start();
                p.WaitForExit();
                string output = p.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
            catch (Exception objException)
            {
                if (objException == null)
                {
                    Console.WriteLine("No se puede acceder, favor de revisar permisos.");
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stopSysMain_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C sc stop \"SysMain\" & sc config \"SysMain\" start=disabled";
            p.Start();
            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            showResult.Text = output;
        }

        private void checkDevicesConnected_Click(object sender, EventArgs e)
        {

            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "devices";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            showResult.Text = output;
        }

        private void checkPowerG_Click(object sender, EventArgs e)
        {
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "adb shell getprop | grep powerg";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            if (output == "")
            {
                showResult.Text = "No Devices Connected.";
            }
            else
            {
                //string output = adb.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
        }

        private void checkSRF_Click(object sender, EventArgs e)
        {
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "adb shell getprop | grep srf";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            if (output == "")
            {
                showResult.Text = "No Devices Connected.";
            }
            else
            {
                //string output = adb.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
        }

        private void checkZwave_Click(object sender, EventArgs e)
        {
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "adb shell getprop | grep zwave";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            if (output == "")
            {
                showResult.Text = "No Devices Connected.";
            }
            else
            {
                //string output = adb.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
        }

        private void checkModem_Click(object sender, EventArgs e)
        {
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "adb shell auto_sendcmd AT+QGMR";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            if (output == "")
            {
                showResult.Text = "No Devices Connected.";
            }
            else
            {
                //string output = adb.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
        }

        private void checkPanelImage_Click(object sender, EventArgs e)
        {
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "adb shell getprop | grep build.date";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            if (output == "")
            {
                showResult.Text = "No Devices Connected.";
            }
            else
            {
                //string output = adb.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
        }

        private void checkDumpsys_Click(object sender, EventArgs e)
        {
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.FileName = "adb.exe";
            adb.StartInfo.Arguments = "adb shell dumpsys battery";
            adb.Start();
            adb.WaitForExit();
            string output = adb.StandardOutput.ReadToEnd();
            if (output == "")
            {
                showResult.Text = "No Devices Connected.";
            }
            else
            {
                //string output = adb.StandardOutput.ReadToEnd();
                showResult.Text = output;
            }
        }
    }
}
