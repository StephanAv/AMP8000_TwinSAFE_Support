using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMP8000_TwinSAFE_Support
{
    public partial class Form1 : Form
    {

        string bat_wraddr;
        string bat_load_project;
        string bat_activate_project;
        string bat_delete_project;
        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select TwinSAFE Binary";
            this.bat_wraddr = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\TwinSAFE_Loader_wraddr.bat";
            this.bat_load_project = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\TwinSAFE_Loader_load_project.bat";
            this.bat_activate_project = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\TwinSAFE_Loader_activate_project.bat";
            this.bat_delete_project = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\TwinSAFE_Loader_delete_project.bat";
        }

        private void btnWriteAddr_Click(object sender, EventArgs e)
        {

            string procArg = string.Format("/C start \"AMP8000 TwinSAFE Support\"  cmd /K \"\"{0}\" {1} {2} {3} {4} {5} \" ",
                                            this.bat_wraddr, 
                                            tbGatewayAddress.Text,
                                            tbTwinSAFEUser.Text,
                                            tbTwinSAFEPassword.Text,
                                            tbSafeAddress.Text,
                                            tbEcSlaveAddr.Text);
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo("cmd.exe", procArg)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    RedirectStandardInput = false,

                }
            };
            proc.Start();
        }


        private void btnSelectBinary_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog(this);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string filename = this.openFileDialog1.FileName;
                this.tbBinaryPath.Text = filename;
            }
        }

        private void btnLoadProject_Click(object sender, EventArgs e)
        {
            string binPath = "\"" + tbBinaryPath.Text.Replace('\\', '/') + "\"";

            string procArg = string.Format("/C start \"AMP8000 TwinSAFE Support\"  cmd /K \"\"{0}\" {1} {2} {3} {4} {5} \" ",
                    this.bat_load_project,
                    tbGatewayAddress.Text,
                    tbTwinSAFEUser.Text,
                    tbTwinSAFEPassword.Text,
                    tbEcSlaveAddr.Text,
                    binPath);
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo("cmd.exe", procArg)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    RedirectStandardInput = false,

                }
            };
            proc.Start();
        }

        private void btnActivateProject_Click(object sender, EventArgs e)
        {
            string binPath = "\"" + tbBinaryPath.Text.Replace('\\', '/') + "\"";
            string procArg = string.Format("/C start \"AMP8000 TwinSAFE Support\"  cmd /K \"\"{0}\" {1} {2} {3} {4} {5} {6} \" ",
            this.bat_activate_project,
            tbGatewayAddress.Text,
            tbTwinSAFEUser.Text,
            tbTwinSAFEPassword.Text,
            tbEcSlaveAddr.Text,
            tbProjectCRC.Text,
            binPath);


            var proc = new Process
            {
                StartInfo = new ProcessStartInfo("cmd.exe", procArg)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    RedirectStandardInput = false,

                }
            };
            proc.Start();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            string procArg = string.Format("/C start \"AMP8000 TwinSAFE Support\"  cmd /K \"\"{0}\" {1} {2} {3} {4}\" ",
            this.bat_delete_project,
            tbGatewayAddress.Text,
            tbTwinSAFEUser.Text,
            tbTwinSAFEPassword.Text,
            tbEcSlaveAddr.Text);


            var proc = new Process
            {
                StartInfo = new ProcessStartInfo("cmd.exe", procArg)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    RedirectStandardInput = false,

                }
            };
            proc.Start();
        }
    }
}
