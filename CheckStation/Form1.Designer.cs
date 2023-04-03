namespace CheckStation
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
            this.sharedQolsys = new System.Windows.Forms.Button();
            this.sharedLogs = new System.Windows.Forms.Button();
            this.buttonDevManager = new System.Windows.Forms.Button();
            this.checkPowerg = new System.Windows.Forms.Button();
            this.showResult = new System.Windows.Forms.TextBox();
            this.checkSrf = new System.Windows.Forms.Button();
            this.checkDumpsys = new System.Windows.Forms.Button();
            this.setpropFactory = new System.Windows.Forms.Button();
            this.checkPanelImage = new System.Windows.Forms.Button();
            this.getpropFactory = new System.Windows.Forms.Button();
            this.checkModem = new System.Windows.Forms.Button();
            this.checkZwave = new System.Windows.Forms.Button();
            this.checkIP = new System.Windows.Forms.Button();
            this.stopSysMain = new System.Windows.Forms.Button();
            this.checkDevicesConnected = new System.Windows.Forms.Button();
            this.checkCtune = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sharedQolsys
            // 
            this.sharedQolsys.AutoSize = true;
            this.sharedQolsys.Location = new System.Drawing.Point(12, 80);
            this.sharedQolsys.Name = "sharedQolsys";
            this.sharedQolsys.Size = new System.Drawing.Size(140, 23);
            this.sharedQolsys.TabIndex = 0;
            this.sharedQolsys.Text = "Compartido 10.19.17.125";
            this.sharedQolsys.UseVisualStyleBackColor = true;
            this.sharedQolsys.Click += new System.EventHandler(this.sharedQolsys_Click);
            // 
            // sharedLogs
            // 
            this.sharedLogs.AutoSize = true;
            this.sharedLogs.Location = new System.Drawing.Point(12, 50);
            this.sharedLogs.Name = "sharedLogs";
            this.sharedLogs.Size = new System.Drawing.Size(140, 24);
            this.sharedLogs.TabIndex = 1;
            this.sharedLogs.Text = "Compartido 10.19.16.101";
            this.sharedLogs.UseVisualStyleBackColor = true;
            this.sharedLogs.Click += new System.EventHandler(this.sharedLogs_Click);
            // 
            // buttonDevManager
            // 
            this.buttonDevManager.AutoSize = true;
            this.buttonDevManager.Location = new System.Drawing.Point(12, 12);
            this.buttonDevManager.Name = "buttonDevManager";
            this.buttonDevManager.Size = new System.Drawing.Size(96, 23);
            this.buttonDevManager.TabIndex = 2;
            this.buttonDevManager.Text = "Device Manager";
            this.buttonDevManager.UseVisualStyleBackColor = true;
            this.buttonDevManager.Click += new System.EventHandler(this.buttonDevManager_Click);
            // 
            // checkPowerg
            // 
            this.checkPowerg.AutoSize = true;
            this.checkPowerg.Location = new System.Drawing.Point(232, 109);
            this.checkPowerg.Name = "checkPowerg";
            this.checkPowerg.Size = new System.Drawing.Size(131, 23);
            this.checkPowerg.TabIndex = 3;
            this.checkPowerg.Text = "Check PowerG";
            this.checkPowerg.UseVisualStyleBackColor = true;
            this.checkPowerg.Click += new System.EventHandler(this.checkPowerG_Click);
            // 
            // showResult
            // 
            this.showResult.Location = new System.Drawing.Point(12, 109);
            this.showResult.Multiline = true;
            this.showResult.Name = "showResult";
            this.showResult.ReadOnly = true;
            this.showResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showResult.Size = new System.Drawing.Size(206, 168);
            this.showResult.TabIndex = 4;
            this.showResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkSrf
            // 
            this.checkSrf.AutoSize = true;
            this.checkSrf.Location = new System.Drawing.Point(232, 138);
            this.checkSrf.Name = "checkSrf";
            this.checkSrf.Size = new System.Drawing.Size(131, 23);
            this.checkSrf.TabIndex = 5;
            this.checkSrf.Text = "Check SRF";
            this.checkSrf.UseVisualStyleBackColor = true;
            this.checkSrf.Click += new System.EventHandler(this.checkSRF_Click);
            // 
            // checkDumpsys
            // 
            this.checkDumpsys.AutoSize = true;
            this.checkDumpsys.Location = new System.Drawing.Point(232, 196);
            this.checkDumpsys.Name = "checkDumpsys";
            this.checkDumpsys.Size = new System.Drawing.Size(131, 23);
            this.checkDumpsys.TabIndex = 6;
            this.checkDumpsys.Text = "Dumpsys Battery";
            this.checkDumpsys.UseVisualStyleBackColor = true;
            this.checkDumpsys.Click += new System.EventHandler(this.checkDumpsys_Click);
            // 
            // setpropFactory
            // 
            this.setpropFactory.AutoSize = true;
            this.setpropFactory.Location = new System.Drawing.Point(232, 254);
            this.setpropFactory.Name = "setpropFactory";
            this.setpropFactory.Size = new System.Drawing.Size(131, 23);
            this.setpropFactory.TabIndex = 7;
            this.setpropFactory.Text = "Setprop qolsys.factory 1";
            this.setpropFactory.UseVisualStyleBackColor = true;
            this.setpropFactory.Click += new System.EventHandler(this.button7_Click);
            // 
            // checkPanelImage
            // 
            this.checkPanelImage.AutoSize = true;
            this.checkPanelImage.Location = new System.Drawing.Point(232, 167);
            this.checkPanelImage.Name = "checkPanelImage";
            this.checkPanelImage.Size = new System.Drawing.Size(131, 23);
            this.checkPanelImage.TabIndex = 8;
            this.checkPanelImage.Text = "Check Panel Image";
            this.checkPanelImage.UseVisualStyleBackColor = true;
            this.checkPanelImage.Click += new System.EventHandler(this.checkPanelImage_Click);
            // 
            // getpropFactory
            // 
            this.getpropFactory.AutoSize = true;
            this.getpropFactory.Location = new System.Drawing.Point(232, 225);
            this.getpropFactory.Name = "getpropFactory";
            this.getpropFactory.Size = new System.Drawing.Size(131, 23);
            this.getpropFactory.TabIndex = 9;
            this.getpropFactory.Text = "Getprop qolsys.factory";
            this.getpropFactory.UseVisualStyleBackColor = true;
            // 
            // checkModem
            // 
            this.checkModem.AutoSize = true;
            this.checkModem.Location = new System.Drawing.Point(385, 109);
            this.checkModem.Name = "checkModem";
            this.checkModem.Size = new System.Drawing.Size(131, 23);
            this.checkModem.TabIndex = 10;
            this.checkModem.Text = "Check Modem";
            this.checkModem.UseVisualStyleBackColor = true;
            this.checkModem.Click += new System.EventHandler(this.checkModem_Click);
            // 
            // checkZwave
            // 
            this.checkZwave.AutoSize = true;
            this.checkZwave.Location = new System.Drawing.Point(385, 138);
            this.checkZwave.Name = "checkZwave";
            this.checkZwave.Size = new System.Drawing.Size(131, 23);
            this.checkZwave.TabIndex = 5;
            this.checkZwave.Text = "Check Zwave";
            this.checkZwave.UseVisualStyleBackColor = true;
            this.checkZwave.Click += new System.EventHandler(this.checkZwave_Click);
            // 
            // checkIP
            // 
            this.checkIP.AutoSize = true;
            this.checkIP.Location = new System.Drawing.Point(385, 196);
            this.checkIP.Name = "checkIP";
            this.checkIP.Size = new System.Drawing.Size(131, 23);
            this.checkIP.TabIndex = 6;
            this.checkIP.Text = "Check IP";
            this.checkIP.UseVisualStyleBackColor = true;
            this.checkIP.Click += new System.EventHandler(this.checkIP_Click);
            // 
            // stopSysMain
            // 
            this.stopSysMain.AutoSize = true;
            this.stopSysMain.Location = new System.Drawing.Point(385, 255);
            this.stopSysMain.Name = "stopSysMain";
            this.stopSysMain.Size = new System.Drawing.Size(131, 23);
            this.stopSysMain.TabIndex = 7;
            this.stopSysMain.Text = "Stop SysMain";
            this.stopSysMain.UseVisualStyleBackColor = true;
            this.stopSysMain.Click += new System.EventHandler(this.stopSysMain_Click);
            // 
            // checkDevicesConnected
            // 
            this.checkDevicesConnected.AutoSize = true;
            this.checkDevicesConnected.Location = new System.Drawing.Point(385, 167);
            this.checkDevicesConnected.Name = "checkDevicesConnected";
            this.checkDevicesConnected.Size = new System.Drawing.Size(131, 23);
            this.checkDevicesConnected.TabIndex = 8;
            this.checkDevicesConnected.Text = "Devices Connected";
            this.checkDevicesConnected.UseVisualStyleBackColor = true;
            this.checkDevicesConnected.Click += new System.EventHandler(this.checkDevicesConnected_Click);
            // 
            // checkCtune
            // 
            this.checkCtune.AutoSize = true;
            this.checkCtune.Location = new System.Drawing.Point(385, 225);
            this.checkCtune.Name = "checkCtune";
            this.checkCtune.Size = new System.Drawing.Size(131, 23);
            this.checkCtune.TabIndex = 9;
            this.checkCtune.Text = "Check Ctune";
            this.checkCtune.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 290);
            this.Controls.Add(this.checkModem);
            this.Controls.Add(this.checkCtune);
            this.Controls.Add(this.checkDevicesConnected);
            this.Controls.Add(this.getpropFactory);
            this.Controls.Add(this.stopSysMain);
            this.Controls.Add(this.checkPanelImage);
            this.Controls.Add(this.checkIP);
            this.Controls.Add(this.setpropFactory);
            this.Controls.Add(this.checkZwave);
            this.Controls.Add(this.checkDumpsys);
            this.Controls.Add(this.checkSrf);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.checkPowerg);
            this.Controls.Add(this.buttonDevManager);
            this.Controls.Add(this.sharedLogs);
            this.Controls.Add(this.sharedQolsys);
            this.Name = "Form1";
            this.Text = "Check Station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sharedQolsys;
        private System.Windows.Forms.Button sharedLogs;
        private System.Windows.Forms.Button buttonDevManager;
        private System.Windows.Forms.Button checkPowerg;
        private System.Windows.Forms.TextBox showResult;
        private System.Windows.Forms.Button checkSrf;
        private System.Windows.Forms.Button checkDumpsys;
        private System.Windows.Forms.Button setpropFactory;
        private System.Windows.Forms.Button checkPanelImage;
        private System.Windows.Forms.Button getpropFactory;
        private System.Windows.Forms.Button checkModem;
        private System.Windows.Forms.Button checkZwave;
        private System.Windows.Forms.Button checkIP;
        private System.Windows.Forms.Button stopSysMain;
        private System.Windows.Forms.Button checkDevicesConnected;
        private System.Windows.Forms.Button checkCtune;
    }
}

