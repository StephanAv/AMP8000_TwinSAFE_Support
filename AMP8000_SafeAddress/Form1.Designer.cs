
namespace AMP8000_TwinSAFE_Support
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGatewayAddress = new System.Windows.Forms.TextBox();
            this.lbl_GatewayAddress = new System.Windows.Forms.Label();
            this.tbTwinSAFEUser = new System.Windows.Forms.TextBox();
            this.tbTwinSAFEPassword = new System.Windows.Forms.TextBox();
            this.tbSafeAddress = new System.Windows.Forms.TextBox();
            this.lblTwinSAFEUser = new System.Windows.Forms.Label();
            this.lblTwinSAFEPassword = new System.Windows.Forms.Label();
            this.lblTwinSAFEAddress = new System.Windows.Forms.Label();
            this.btnWriteAddr = new System.Windows.Forms.Button();
            this.lblEcSlaveAddr = new System.Windows.Forms.Label();
            this.tbEcSlaveAddr = new System.Windows.Forms.TextBox();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.btnActivateProject = new System.Windows.Forms.Button();
            this.btnSelectBinary = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbBinaryPath = new System.Windows.Forms.TextBox();
            this.grpBoxGeneral = new System.Windows.Forms.GroupBox();
            this.grpBoxSafeAddress = new System.Windows.Forms.GroupBox();
            this.grpBoxProjectDownload = new System.Windows.Forms.GroupBox();
            this.grpBoxProjectActivate = new System.Windows.Forms.GroupBox();
            this.tbProjectCRC = new System.Windows.Forms.TextBox();
            this.lblProjectCRC = new System.Windows.Forms.Label();
            this.grpBoxProjectDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpBoxGeneral.SuspendLayout();
            this.grpBoxSafeAddress.SuspendLayout();
            this.grpBoxProjectDownload.SuspendLayout();
            this.grpBoxProjectActivate.SuspendLayout();
            this.grpBoxProjectDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGatewayAddress
            // 
            this.tbGatewayAddress.Location = new System.Drawing.Point(259, 32);
            this.tbGatewayAddress.Name = "tbGatewayAddress";
            this.tbGatewayAddress.Size = new System.Drawing.Size(100, 20);
            this.tbGatewayAddress.TabIndex = 0;
            this.tbGatewayAddress.Text = "192.168.67.254";
            this.tbGatewayAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_GatewayAddress
            // 
            this.lbl_GatewayAddress.AutoSize = true;
            this.lbl_GatewayAddress.Location = new System.Drawing.Point(22, 32);
            this.lbl_GatewayAddress.Name = "lbl_GatewayAddress";
            this.lbl_GatewayAddress.Size = new System.Drawing.Size(137, 13);
            this.lbl_GatewayAddress.TabIndex = 1;
            this.lbl_GatewayAddress.Text = "EtherCAT Mailbox Gateway";
            // 
            // tbTwinSAFEUser
            // 
            this.tbTwinSAFEUser.Location = new System.Drawing.Point(200, 67);
            this.tbTwinSAFEUser.Name = "tbTwinSAFEUser";
            this.tbTwinSAFEUser.Size = new System.Drawing.Size(159, 20);
            this.tbTwinSAFEUser.TabIndex = 2;
            this.tbTwinSAFEUser.Text = "Administrator";
            this.tbTwinSAFEUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTwinSAFEPassword
            // 
            this.tbTwinSAFEPassword.Location = new System.Drawing.Point(200, 104);
            this.tbTwinSAFEPassword.Name = "tbTwinSAFEPassword";
            this.tbTwinSAFEPassword.Size = new System.Drawing.Size(159, 20);
            this.tbTwinSAFEPassword.TabIndex = 3;
            this.tbTwinSAFEPassword.Text = "TwinSAFE";
            this.tbTwinSAFEPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSafeAddress
            // 
            this.tbSafeAddress.Location = new System.Drawing.Point(259, 27);
            this.tbSafeAddress.Name = "tbSafeAddress";
            this.tbSafeAddress.Size = new System.Drawing.Size(100, 20);
            this.tbSafeAddress.TabIndex = 4;
            this.tbSafeAddress.Text = "42";
            this.tbSafeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTwinSAFEUser
            // 
            this.lblTwinSAFEUser.AutoSize = true;
            this.lblTwinSAFEUser.Location = new System.Drawing.Point(22, 67);
            this.lblTwinSAFEUser.Name = "lblTwinSAFEUser";
            this.lblTwinSAFEUser.Size = new System.Drawing.Size(86, 13);
            this.lblTwinSAFEUser.TabIndex = 5;
            this.lblTwinSAFEUser.Text = "TwinSAFE Login";
            // 
            // lblTwinSAFEPassword
            // 
            this.lblTwinSAFEPassword.AutoSize = true;
            this.lblTwinSAFEPassword.Location = new System.Drawing.Point(22, 107);
            this.lblTwinSAFEPassword.Name = "lblTwinSAFEPassword";
            this.lblTwinSAFEPassword.Size = new System.Drawing.Size(106, 13);
            this.lblTwinSAFEPassword.TabIndex = 6;
            this.lblTwinSAFEPassword.Text = "TwinSAFE Password";
            // 
            // lblTwinSAFEAddress
            // 
            this.lblTwinSAFEAddress.AutoSize = true;
            this.lblTwinSAFEAddress.Location = new System.Drawing.Point(6, 30);
            this.lblTwinSAFEAddress.Name = "lblTwinSAFEAddress";
            this.lblTwinSAFEAddress.Size = new System.Drawing.Size(98, 13);
            this.lblTwinSAFEAddress.TabIndex = 7;
            this.lblTwinSAFEAddress.Text = "TwinSAFE Address";
            // 
            // btnWriteAddr
            // 
            this.btnWriteAddr.Location = new System.Drawing.Point(9, 62);
            this.btnWriteAddr.Name = "btnWriteAddr";
            this.btnWriteAddr.Size = new System.Drawing.Size(350, 23);
            this.btnWriteAddr.TabIndex = 8;
            this.btnWriteAddr.Text = "Write TwinSAFE Address";
            this.btnWriteAddr.UseVisualStyleBackColor = true;
            this.btnWriteAddr.Click += new System.EventHandler(this.btnWriteAddr_Click);
            // 
            // lblEcSlaveAddr
            // 
            this.lblEcSlaveAddr.AutoSize = true;
            this.lblEcSlaveAddr.Location = new System.Drawing.Point(23, 144);
            this.lblEcSlaveAddr.Name = "lblEcSlaveAddr";
            this.lblEcSlaveAddr.Size = new System.Drawing.Size(124, 13);
            this.lblEcSlaveAddr.TabIndex = 9;
            this.lblEcSlaveAddr.Text = "EtherCAT Slave Address";
            // 
            // tbEcSlaveAddr
            // 
            this.tbEcSlaveAddr.Location = new System.Drawing.Point(259, 141);
            this.tbEcSlaveAddr.Name = "tbEcSlaveAddr";
            this.tbEcSlaveAddr.Size = new System.Drawing.Size(100, 20);
            this.tbEcSlaveAddr.TabIndex = 10;
            this.tbEcSlaveAddr.Text = "1001";
            this.tbEcSlaveAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Location = new System.Drawing.Point(18, 111);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(341, 23);
            this.btnLoadProject.TabIndex = 11;
            this.btnLoadProject.Text = "Load TwinSAFE Project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // btnActivateProject
            // 
            this.btnActivateProject.Location = new System.Drawing.Point(18, 56);
            this.btnActivateProject.Name = "btnActivateProject";
            this.btnActivateProject.Size = new System.Drawing.Size(341, 23);
            this.btnActivateProject.TabIndex = 12;
            this.btnActivateProject.Text = "Activate TwinSAFE Project";
            this.btnActivateProject.UseVisualStyleBackColor = true;
            this.btnActivateProject.Click += new System.EventHandler(this.btnActivateProject_Click);
            // 
            // btnSelectBinary
            // 
            this.btnSelectBinary.Location = new System.Drawing.Point(18, 31);
            this.btnSelectBinary.Name = "btnSelectBinary";
            this.btnSelectBinary.Size = new System.Drawing.Size(341, 23);
            this.btnSelectBinary.TabIndex = 13;
            this.btnSelectBinary.Text = "Select TwinSAFE Proeject";
            this.btnSelectBinary.UseVisualStyleBackColor = true;
            this.btnSelectBinary.Click += new System.EventHandler(this.btnSelectBinary_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbBinaryPath
            // 
            this.tbBinaryPath.Location = new System.Drawing.Point(18, 71);
            this.tbBinaryPath.Name = "tbBinaryPath";
            this.tbBinaryPath.Size = new System.Drawing.Size(341, 20);
            this.tbBinaryPath.TabIndex = 14;
            this.tbBinaryPath.Text = "TwinSAFEProject.bin";
            // 
            // grpBoxGeneral
            // 
            this.grpBoxGeneral.Controls.Add(this.lbl_GatewayAddress);
            this.grpBoxGeneral.Controls.Add(this.tbGatewayAddress);
            this.grpBoxGeneral.Controls.Add(this.tbTwinSAFEUser);
            this.grpBoxGeneral.Controls.Add(this.tbTwinSAFEPassword);
            this.grpBoxGeneral.Controls.Add(this.lblTwinSAFEUser);
            this.grpBoxGeneral.Controls.Add(this.tbEcSlaveAddr);
            this.grpBoxGeneral.Controls.Add(this.lblTwinSAFEPassword);
            this.grpBoxGeneral.Controls.Add(this.lblEcSlaveAddr);
            this.grpBoxGeneral.Location = new System.Drawing.Point(12, 12);
            this.grpBoxGeneral.Name = "grpBoxGeneral";
            this.grpBoxGeneral.Size = new System.Drawing.Size(376, 170);
            this.grpBoxGeneral.TabIndex = 15;
            this.grpBoxGeneral.TabStop = false;
            this.grpBoxGeneral.Text = "General";
            // 
            // grpBoxSafeAddress
            // 
            this.grpBoxSafeAddress.Controls.Add(this.lblTwinSAFEAddress);
            this.grpBoxSafeAddress.Controls.Add(this.tbSafeAddress);
            this.grpBoxSafeAddress.Controls.Add(this.btnWriteAddr);
            this.grpBoxSafeAddress.Location = new System.Drawing.Point(12, 193);
            this.grpBoxSafeAddress.Name = "grpBoxSafeAddress";
            this.grpBoxSafeAddress.Size = new System.Drawing.Size(376, 100);
            this.grpBoxSafeAddress.TabIndex = 16;
            this.grpBoxSafeAddress.TabStop = false;
            this.grpBoxSafeAddress.Text = "Safe Address";
            // 
            // grpBoxProjectDownload
            // 
            this.grpBoxProjectDownload.Controls.Add(this.btnSelectBinary);
            this.grpBoxProjectDownload.Controls.Add(this.tbBinaryPath);
            this.grpBoxProjectDownload.Controls.Add(this.btnLoadProject);
            this.grpBoxProjectDownload.Location = new System.Drawing.Point(12, 313);
            this.grpBoxProjectDownload.Name = "grpBoxProjectDownload";
            this.grpBoxProjectDownload.Size = new System.Drawing.Size(376, 154);
            this.grpBoxProjectDownload.TabIndex = 17;
            this.grpBoxProjectDownload.TabStop = false;
            this.grpBoxProjectDownload.Text = "Safety Project - Download";
            // 
            // grpBoxProjectActivate
            // 
            this.grpBoxProjectActivate.Controls.Add(this.tbProjectCRC);
            this.grpBoxProjectActivate.Controls.Add(this.lblProjectCRC);
            this.grpBoxProjectActivate.Controls.Add(this.btnActivateProject);
            this.grpBoxProjectActivate.Location = new System.Drawing.Point(12, 483);
            this.grpBoxProjectActivate.Name = "grpBoxProjectActivate";
            this.grpBoxProjectActivate.Size = new System.Drawing.Size(376, 94);
            this.grpBoxProjectActivate.TabIndex = 18;
            this.grpBoxProjectActivate.TabStop = false;
            this.grpBoxProjectActivate.Text = "Safety Project - Activate";
            // 
            // tbProjectCRC
            // 
            this.tbProjectCRC.Location = new System.Drawing.Point(259, 30);
            this.tbProjectCRC.Name = "tbProjectCRC";
            this.tbProjectCRC.Size = new System.Drawing.Size(100, 20);
            this.tbProjectCRC.TabIndex = 14;
            this.tbProjectCRC.Text = "0xabcd";
            this.tbProjectCRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProjectCRC
            // 
            this.lblProjectCRC.AutoSize = true;
            this.lblProjectCRC.Location = new System.Drawing.Point(18, 30);
            this.lblProjectCRC.Name = "lblProjectCRC";
            this.lblProjectCRC.Size = new System.Drawing.Size(65, 13);
            this.lblProjectCRC.TabIndex = 13;
            this.lblProjectCRC.Text = "Project CRC";
            // 
            // grpBoxProjectDelete
            // 
            this.grpBoxProjectDelete.Controls.Add(this.btnDeleteProject);
            this.grpBoxProjectDelete.Location = new System.Drawing.Point(12, 593);
            this.grpBoxProjectDelete.Name = "grpBoxProjectDelete";
            this.grpBoxProjectDelete.Size = new System.Drawing.Size(376, 72);
            this.grpBoxProjectDelete.TabIndex = 19;
            this.grpBoxProjectDelete.TabStop = false;
            this.grpBoxProjectDelete.Text = "Safety Project - Delete";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(18, 36);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(341, 23);
            this.btnDeleteProject.TabIndex = 0;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 675);
            this.Controls.Add(this.grpBoxProjectDelete);
            this.Controls.Add(this.grpBoxProjectActivate);
            this.Controls.Add(this.grpBoxProjectDownload);
            this.Controls.Add(this.grpBoxSafeAddress);
            this.Controls.Add(this.grpBoxGeneral);
            this.Name = "Form1";
            this.Text = "AMP8000 TwinSAFE Support 0.10";
            this.grpBoxGeneral.ResumeLayout(false);
            this.grpBoxGeneral.PerformLayout();
            this.grpBoxSafeAddress.ResumeLayout(false);
            this.grpBoxSafeAddress.PerformLayout();
            this.grpBoxProjectDownload.ResumeLayout(false);
            this.grpBoxProjectDownload.PerformLayout();
            this.grpBoxProjectActivate.ResumeLayout(false);
            this.grpBoxProjectActivate.PerformLayout();
            this.grpBoxProjectDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbGatewayAddress;
        private System.Windows.Forms.Label lbl_GatewayAddress;
        private System.Windows.Forms.TextBox tbTwinSAFEUser;
        private System.Windows.Forms.TextBox tbTwinSAFEPassword;
        private System.Windows.Forms.TextBox tbSafeAddress;
        private System.Windows.Forms.Label lblTwinSAFEUser;
        private System.Windows.Forms.Label lblTwinSAFEPassword;
        private System.Windows.Forms.Label lblTwinSAFEAddress;
        private System.Windows.Forms.Button btnWriteAddr;
        private System.Windows.Forms.Label lblEcSlaveAddr;
        private System.Windows.Forms.TextBox tbEcSlaveAddr;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.Button btnActivateProject;
        private System.Windows.Forms.Button btnSelectBinary;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbBinaryPath;
        private System.Windows.Forms.GroupBox grpBoxGeneral;
        private System.Windows.Forms.GroupBox grpBoxSafeAddress;
        private System.Windows.Forms.GroupBox grpBoxProjectDownload;
        private System.Windows.Forms.GroupBox grpBoxProjectActivate;
        private System.Windows.Forms.Label lblProjectCRC;
        private System.Windows.Forms.TextBox tbProjectCRC;
        private System.Windows.Forms.GroupBox grpBoxProjectDelete;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

