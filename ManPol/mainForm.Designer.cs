namespace ManPol
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbMtr = new System.Windows.Forms.ComboBox();
            this.cbMtrPos = new System.Windows.Forms.ComboBox();
            this.btnMoveMtr = new System.Windows.Forms.Button();
            this.lblMtr = new System.Windows.Forms.Label();
            this.lblMtrPos = new System.Windows.Forms.Label();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tbToSend = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.vHWPgrp = new System.Windows.Forms.GroupBox();
            this.vPos3 = new System.Windows.Forms.RadioButton();
            this.vPos2 = new System.Windows.Forms.RadioButton();
            this.vPos1 = new System.Windows.Forms.RadioButton();
            this.vPos0 = new System.Windows.Forms.RadioButton();
            this.LAgrp = new System.Windows.Forms.GroupBox();
            this.iLight = new System.Windows.Forms.RadioButton();
            this.oLight = new System.Windows.Forms.RadioButton();
            this.vLight = new System.Windows.Forms.RadioButton();
            this.iHWPgrp = new System.Windows.Forms.GroupBox();
            this.iPos3 = new System.Windows.Forms.RadioButton();
            this.iPos2 = new System.Windows.Forms.RadioButton();
            this.iPos1 = new System.Windows.Forms.RadioButton();
            this.iPos0 = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblNOTHOMED = new System.Windows.Forms.Label();
            this.lblFwVers = new System.Windows.Forms.Label();
            this.lblVLIMITSWITCHPROB = new System.Windows.Forms.Label();
            this.lblILIMITSWITCHPROB = new System.Windows.Forms.Label();
            this.btnUptime = new System.Windows.Forms.Button();
            this.lblLLIMITSWITCHPROB = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vHWPgrp.SuspendLayout();
            this.LAgrp.SuspendLayout();
            this.iHWPgrp.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCom
            // 
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(31, 29);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 1;
            this.cbCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCom_KeyPress);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(158, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(239, 27);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbMtr
            // 
            this.cbMtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMtr.FormattingEnabled = true;
            this.cbMtr.Location = new System.Drawing.Point(364, 27);
            this.cbMtr.Name = "cbMtr";
            this.cbMtr.Size = new System.Drawing.Size(42, 21);
            this.cbMtr.TabIndex = 4;
            this.cbMtr.SelectedIndexChanged += new System.EventHandler(this.cbMtr_SelectedIndexChanged);
            // 
            // cbMtrPos
            // 
            this.cbMtrPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMtrPos.FormattingEnabled = true;
            this.cbMtrPos.Location = new System.Drawing.Point(460, 27);
            this.cbMtrPos.Name = "cbMtrPos";
            this.cbMtrPos.Size = new System.Drawing.Size(66, 21);
            this.cbMtrPos.TabIndex = 5;
            // 
            // btnMoveMtr
            // 
            this.btnMoveMtr.Location = new System.Drawing.Point(532, 27);
            this.btnMoveMtr.Name = "btnMoveMtr";
            this.btnMoveMtr.Size = new System.Drawing.Size(66, 23);
            this.btnMoveMtr.TabIndex = 6;
            this.btnMoveMtr.Text = "Move";
            this.btnMoveMtr.UseVisualStyleBackColor = true;
            this.btnMoveMtr.Click += new System.EventHandler(this.btnMoveMtr_Click);
            // 
            // lblMtr
            // 
            this.lblMtr.AutoSize = true;
            this.lblMtr.Location = new System.Drawing.Point(327, 30);
            this.lblMtr.Name = "lblMtr";
            this.lblMtr.Size = new System.Drawing.Size(34, 13);
            this.lblMtr.TabIndex = 7;
            this.lblMtr.Text = "Motor";
            // 
            // lblMtrPos
            // 
            this.lblMtrPos.AutoSize = true;
            this.lblMtrPos.Location = new System.Drawing.Point(412, 30);
            this.lblMtrPos.Name = "lblMtrPos";
            this.lblMtrPos.Size = new System.Drawing.Size(44, 13);
            this.lblMtrPos.TabIndex = 8;
            this.lblMtrPos.Text = "Position";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(532, 56);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(66, 23);
            this.btnGetStatus.TabIndex = 9;
            this.btnGetStatus.Text = "Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(460, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(66, 23);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tbToSend
            // 
            this.tbToSend.Location = new System.Drawing.Point(340, 215);
            this.tbToSend.Name = "tbToSend";
            this.tbToSend.Size = new System.Drawing.Size(186, 20);
            this.tbToSend.TabIndex = 11;
            this.tbToSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbToSend_KeyPress);
            // 
            // tbLog
            // 
            this.tbLog.DetectUrls = false;
            this.tbLog.Location = new System.Drawing.Point(340, 94);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(258, 113);
            this.tbLog.TabIndex = 12;
            this.tbLog.Text = "";
            // 
            // vHWPgrp
            // 
            this.vHWPgrp.BackColor = System.Drawing.Color.IndianRed;
            this.vHWPgrp.Controls.Add(this.vPos3);
            this.vHWPgrp.Controls.Add(this.vPos2);
            this.vHWPgrp.Controls.Add(this.vPos1);
            this.vHWPgrp.Controls.Add(this.vPos0);
            this.vHWPgrp.Location = new System.Drawing.Point(31, 94);
            this.vHWPgrp.Name = "vHWPgrp";
            this.vHWPgrp.Size = new System.Drawing.Size(84, 124);
            this.vHWPgrp.TabIndex = 13;
            this.vHWPgrp.TabStop = false;
            this.vHWPgrp.Text = "V-band HWP";
            // 
            // vPos3
            // 
            this.vPos3.AutoCheck = false;
            this.vPos3.AutoSize = true;
            this.vPos3.Location = new System.Drawing.Point(7, 90);
            this.vPos3.Name = "vPos3";
            this.vPos3.Size = new System.Drawing.Size(46, 17);
            this.vPos3.TabIndex = 3;
            this.vPos3.Text = "67.5";
            this.vPos3.UseVisualStyleBackColor = true;
            // 
            // vPos2
            // 
            this.vPos2.AutoCheck = false;
            this.vPos2.AutoSize = true;
            this.vPos2.Location = new System.Drawing.Point(7, 67);
            this.vPos2.Name = "vPos2";
            this.vPos2.Size = new System.Drawing.Size(37, 17);
            this.vPos2.TabIndex = 2;
            this.vPos2.Text = "45";
            this.vPos2.UseVisualStyleBackColor = true;
            // 
            // vPos1
            // 
            this.vPos1.AutoCheck = false;
            this.vPos1.AutoSize = true;
            this.vPos1.Location = new System.Drawing.Point(7, 44);
            this.vPos1.Name = "vPos1";
            this.vPos1.Size = new System.Drawing.Size(46, 17);
            this.vPos1.TabIndex = 1;
            this.vPos1.Text = "22.5";
            this.vPos1.UseVisualStyleBackColor = true;
            // 
            // vPos0
            // 
            this.vPos0.AutoCheck = false;
            this.vPos0.AutoSize = true;
            this.vPos0.Location = new System.Drawing.Point(7, 21);
            this.vPos0.Name = "vPos0";
            this.vPos0.Size = new System.Drawing.Size(31, 17);
            this.vPos0.TabIndex = 0;
            this.vPos0.Text = "0";
            this.vPos0.UseVisualStyleBackColor = true;
            // 
            // LAgrp
            // 
            this.LAgrp.BackColor = System.Drawing.Color.IndianRed;
            this.LAgrp.Controls.Add(this.iLight);
            this.LAgrp.Controls.Add(this.oLight);
            this.LAgrp.Controls.Add(this.vLight);
            this.LAgrp.Location = new System.Drawing.Point(121, 94);
            this.LAgrp.Name = "LAgrp";
            this.LAgrp.Size = new System.Drawing.Size(84, 124);
            this.LAgrp.TabIndex = 14;
            this.LAgrp.TabStop = false;
            this.LAgrp.Text = "Sliding Tray";
            // 
            // iLight
            // 
            this.iLight.AutoCheck = false;
            this.iLight.AutoSize = true;
            this.iLight.Location = new System.Drawing.Point(7, 67);
            this.iLight.Name = "iLight";
            this.iLight.Size = new System.Drawing.Size(56, 17);
            this.iLight.TabIndex = 2;
            this.iLight.Text = "I-Band";
            this.iLight.UseVisualStyleBackColor = true;
            // 
            // oLight
            // 
            this.oLight.AutoCheck = false;
            this.oLight.AutoSize = true;
            this.oLight.Location = new System.Drawing.Point(7, 44);
            this.oLight.Name = "oLight";
            this.oLight.Size = new System.Drawing.Size(51, 17);
            this.oLight.TabIndex = 1;
            this.oLight.Text = "Open";
            this.oLight.UseVisualStyleBackColor = true;
            // 
            // vLight
            // 
            this.vLight.AutoCheck = false;
            this.vLight.AutoSize = true;
            this.vLight.Location = new System.Drawing.Point(7, 21);
            this.vLight.Name = "vLight";
            this.vLight.Size = new System.Drawing.Size(60, 17);
            this.vLight.TabIndex = 0;
            this.vLight.Text = "V-Band";
            this.vLight.UseVisualStyleBackColor = true;
            // 
            // iHWPgrp
            // 
            this.iHWPgrp.BackColor = System.Drawing.Color.IndianRed;
            this.iHWPgrp.Controls.Add(this.iPos3);
            this.iHWPgrp.Controls.Add(this.iPos2);
            this.iHWPgrp.Controls.Add(this.iPos1);
            this.iHWPgrp.Controls.Add(this.iPos0);
            this.iHWPgrp.Location = new System.Drawing.Point(211, 94);
            this.iHWPgrp.Name = "iHWPgrp";
            this.iHWPgrp.Size = new System.Drawing.Size(84, 124);
            this.iHWPgrp.TabIndex = 14;
            this.iHWPgrp.TabStop = false;
            this.iHWPgrp.Text = "I-band HWP";
            // 
            // iPos3
            // 
            this.iPos3.AutoCheck = false;
            this.iPos3.AutoSize = true;
            this.iPos3.Location = new System.Drawing.Point(7, 90);
            this.iPos3.Name = "iPos3";
            this.iPos3.Size = new System.Drawing.Size(46, 17);
            this.iPos3.TabIndex = 3;
            this.iPos3.Text = "67.5";
            this.iPos3.UseVisualStyleBackColor = true;
            // 
            // iPos2
            // 
            this.iPos2.AutoCheck = false;
            this.iPos2.AutoSize = true;
            this.iPos2.Location = new System.Drawing.Point(6, 67);
            this.iPos2.Name = "iPos2";
            this.iPos2.Size = new System.Drawing.Size(37, 17);
            this.iPos2.TabIndex = 2;
            this.iPos2.Text = "45";
            this.iPos2.UseVisualStyleBackColor = true;
            // 
            // iPos1
            // 
            this.iPos1.AutoCheck = false;
            this.iPos1.AutoSize = true;
            this.iPos1.Location = new System.Drawing.Point(7, 44);
            this.iPos1.Name = "iPos1";
            this.iPos1.Size = new System.Drawing.Size(46, 17);
            this.iPos1.TabIndex = 1;
            this.iPos1.Text = "22.5";
            this.iPos1.UseVisualStyleBackColor = true;
            // 
            // iPos0
            // 
            this.iPos0.AutoCheck = false;
            this.iPos0.AutoSize = true;
            this.iPos0.Location = new System.Drawing.Point(7, 21);
            this.iPos0.Name = "iPos0";
            this.iPos0.Size = new System.Drawing.Size(31, 17);
            this.iPos0.TabIndex = 0;
            this.iPos0.Text = "0";
            this.iPos0.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(532, 213);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblNOTHOMED
            // 
            this.lblNOTHOMED.AutoSize = true;
            this.lblNOTHOMED.BackColor = System.Drawing.Color.IndianRed;
            this.lblNOTHOMED.Location = new System.Drawing.Point(55, 75);
            this.lblNOTHOMED.Name = "lblNOTHOMED";
            this.lblNOTHOMED.Size = new System.Drawing.Size(209, 13);
            this.lblNOTHOMED.TabIndex = 16;
            this.lblNOTHOMED.Text = "ONE OR MORE MOTOR IS NOT HOMED";
            // 
            // lblFwVers
            // 
            this.lblFwVers.AutoSize = true;
            this.lblFwVers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFwVers.Location = new System.Drawing.Point(498, 238);
            this.lblFwVers.Name = "lblFwVers";
            this.lblFwVers.Size = new System.Drawing.Size(53, 13);
            this.lblFwVers.TabIndex = 18;
            this.lblFwVers.Text = "Unknown";
            // 
            // lblVLIMITSWITCHPROB
            // 
            this.lblVLIMITSWITCHPROB.AutoSize = true;
            this.lblVLIMITSWITCHPROB.BackColor = System.Drawing.Color.Red;
            this.lblVLIMITSWITCHPROB.Location = new System.Drawing.Point(35, 221);
            this.lblVLIMITSWITCHPROB.Name = "lblVLIMITSWITCHPROB";
            this.lblVLIMITSWITCHPROB.Size = new System.Drawing.Size(78, 13);
            this.lblVLIMITSWITCHPROB.TabIndex = 20;
            this.lblVLIMITSWITCHPROB.Text = "LIMITSWITCH";
            this.lblVLIMITSWITCHPROB.Visible = false;
            // 
            // lblILIMITSWITCHPROB
            // 
            this.lblILIMITSWITCHPROB.AutoSize = true;
            this.lblILIMITSWITCHPROB.BackColor = System.Drawing.Color.Red;
            this.lblILIMITSWITCHPROB.Location = new System.Drawing.Point(214, 221);
            this.lblILIMITSWITCHPROB.Name = "lblILIMITSWITCHPROB";
            this.lblILIMITSWITCHPROB.Size = new System.Drawing.Size(78, 13);
            this.lblILIMITSWITCHPROB.TabIndex = 21;
            this.lblILIMITSWITCHPROB.Text = "LIMITSWITCH";
            this.lblILIMITSWITCHPROB.Visible = false;
            // 
            // btnUptime
            // 
            this.btnUptime.Location = new System.Drawing.Point(388, 56);
            this.btnUptime.Name = "btnUptime";
            this.btnUptime.Size = new System.Drawing.Size(66, 23);
            this.btnUptime.TabIndex = 22;
            this.btnUptime.Text = "Uptime";
            this.btnUptime.UseVisualStyleBackColor = true;
            this.btnUptime.Click += new System.EventHandler(this.btnUptime_Click);
            // 
            // lblLLIMITSWITCHPROB
            // 
            this.lblLLIMITSWITCHPROB.AutoSize = true;
            this.lblLLIMITSWITCHPROB.BackColor = System.Drawing.Color.Red;
            this.lblLLIMITSWITCHPROB.Location = new System.Drawing.Point(125, 221);
            this.lblLLIMITSWITCHPROB.Name = "lblLLIMITSWITCHPROB";
            this.lblLLIMITSWITCHPROB.Size = new System.Drawing.Size(78, 13);
            this.lblLLIMITSWITCHPROB.TabIndex = 23;
            this.lblLLIMITSWITCHPROB.Text = "LIMITSWITCH";
            this.lblLLIMITSWITCHPROB.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 258);
            this.Controls.Add(this.lblLLIMITSWITCHPROB);
            this.Controls.Add(this.btnUptime);
            this.Controls.Add(this.lblILIMITSWITCHPROB);
            this.Controls.Add(this.lblVLIMITSWITCHPROB);
            this.Controls.Add(this.lblFwVers);
            this.Controls.Add(this.lblNOTHOMED);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.iHWPgrp);
            this.Controls.Add(this.LAgrp);
            this.Controls.Add(this.vHWPgrp);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.tbToSend);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.lblMtrPos);
            this.Controls.Add(this.lblMtr);
            this.Controls.Add(this.btnMoveMtr);
            this.Controls.Add(this.cbMtrPos);
            this.Controls.Add(this.cbMtr);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Manual Polarimeter Mover [v0.2]";
            this.vHWPgrp.ResumeLayout(false);
            this.vHWPgrp.PerformLayout();
            this.LAgrp.ResumeLayout(false);
            this.LAgrp.PerformLayout();
            this.iHWPgrp.ResumeLayout(false);
            this.iHWPgrp.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox cbMtr;
        private System.Windows.Forms.ComboBox cbMtrPos;
        private System.Windows.Forms.Button btnMoveMtr;
        private System.Windows.Forms.Label lblMtr;
        private System.Windows.Forms.Label lblMtrPos;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox tbToSend;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.GroupBox vHWPgrp;
        private System.Windows.Forms.GroupBox LAgrp;
        private System.Windows.Forms.GroupBox iHWPgrp;
        private System.Windows.Forms.RadioButton vPos0;
        private System.Windows.Forms.RadioButton vPos3;
        private System.Windows.Forms.RadioButton vPos2;
        private System.Windows.Forms.RadioButton vPos1;
        private System.Windows.Forms.RadioButton iPos3;
        private System.Windows.Forms.RadioButton iPos2;
        private System.Windows.Forms.RadioButton iPos1;
        private System.Windows.Forms.RadioButton iPos0;
        private System.Windows.Forms.RadioButton iLight;
        private System.Windows.Forms.RadioButton oLight;
        private System.Windows.Forms.RadioButton vLight;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblNOTHOMED;
        private System.Windows.Forms.Label lblFwVers;
        private System.Windows.Forms.Label lblVLIMITSWITCHPROB;
        private System.Windows.Forms.Label lblILIMITSWITCHPROB;
        private System.Windows.Forms.Button btnUptime;
        private System.Windows.Forms.Label lblLLIMITSWITCHPROB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

