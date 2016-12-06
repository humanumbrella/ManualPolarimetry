using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace ManPol
{
    public partial class mainForm : Form
    {
        //need a delegate method which accepts a string
        public delegate void AddDataDelegate(String loggedText);
        //create one to use...
        public AddDataDelegate logDel;

        private string delimChar = "+";
        private string moveCmd = "";
        private string lastPos = "";
        private string pinStats = "";

        private int trayPos;
        public int TrayPos { get { return trayPos; } set { 
            trayPos = value; 
        } }
        private int vPos;
        public int VPos { get {return vPos;} set { 
            if (vPos == value) {
                //dont do anything, already there
                return;
            }
            int timeMove = Math.Abs(vPos - value);
            vPos = value; 
            //sets cbMtr.Text to V
            cbMtr.SelectedIndex = 0;
            cbMtrPos.Enabled = true;
            cbMtrPos.SelectedIndex = vPos;
            btnMoveMtr_Click(this, new EventArgs());
            waitFor((ushort)(timeMove*3000)); // wait 100ms
        } }
        private int iPos;
        public int IPos
        {
            get { return iPos; }
            set
            {
                iPos = value;
                cbMtr.SelectedIndex = 1;
                cbMtrPos.Enabled = true;
                cbMtrPos.SelectedIndex = iPos;
                btnMoveMtr_Click(this, new EventArgs());
            }
        }


        SerialPort ser = new SerialPort();

        public mainForm()
        {
            InitializeComponent();

            this.logDel = new AddDataDelegate(logSerialText);
            string[] ArrayComPortsNames = null;

            ArrayComPortsNames = SerialPort.GetPortNames();


            if (ArrayComPortsNames.Length != 0)
            {

                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    cbCom.Items.Add(ArrayComPortsNames[i]);
                }
                cbCom.SelectedIndex = 0;
                btnDisconnect.Enabled = false;
                btnMoveMtr.Enabled = false;
                cbMtr.Enabled = false;
                cbMtrPos.Enabled = false;

                cbMtr.Items.Add("V");
                cbMtr.Items.Add("I");
                cbMtr.Items.Add("L");
                

                cbMtrPos.Items.Add("0");
                cbMtrPos.Items.Add("22.5");
                cbMtrPos.Items.Add("45");
                cbMtrPos.Items.Add("67.5");
                cbMtrPos.SelectedIndex = 0;
                cbMtrPos.Enabled = false;
            }
            else
            {
                cbCom.Items.Add("No COM ports");
                cbCom.SelectedIndex = 0;
            }
            //hide all UI components
            toggleUI(true);

        }

        public mainForm(Form sender, bool autoConnect, string com)
        {
            InitializeComponent();
            //hide all UI components
            toggleUI(true);

            this.logDel = new AddDataDelegate(logSerialText);
            string[] ArrayComPortsNames = null;

            ArrayComPortsNames = SerialPort.GetPortNames();


            if (ArrayComPortsNames.Length != 0)
            {

                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    cbCom.Items.Add(ArrayComPortsNames[i]);
                }
                cbCom.SelectedIndex = 0;
                btnDisconnect.Enabled = false;
                btnMoveMtr.Enabled = false;
                cbMtr.Enabled = false;
                cbMtrPos.Enabled = false;

                cbMtr.Items.Add("V");
                cbMtr.Items.Add("I");
                cbMtr.Items.Add("L");


                cbMtrPos.Items.Add("0");
                cbMtrPos.Items.Add("22.5");
                cbMtrPos.Items.Add("45");
                cbMtrPos.Items.Add("67.5");
                cbMtrPos.SelectedIndex = 0;
                cbMtrPos.Enabled = false;
            }
            else
            {
                cbCom.Items.Add("No COM ports");
                cbCom.SelectedIndex = 0;
            }
            if (autoConnect){
                cbCom.Text = com;
                btnConnect_Click(this, new EventArgs());
            }


        }
        //establish serial connection
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ser.PortName = cbCom.Text;
                ser.BaudRate = 57600;
                ser.DtrEnable = false;
                ser.DataReceived += new SerialDataReceivedEventHandler(receiveSer);
                ser.Open();
                tbLog.Text = "";
                logLine("Connected");
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                System.Threading.Thread.Sleep(250);
                ser.Write("#+");
                ser.Write("V+");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            cbMtr.Enabled = true;
            toggleUI(false);            
        }
        //receiving serial data event handler
        private void receiveSer(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string s = ser.ReadTo(delimChar);
                Console.WriteLine(s);
                tbLog.Invoke(this.logDel, new Object[] { s });
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void logLine(string line)
        {
            tbLog.Select(0, 0);
            tbLog.SelectedText = line+"\n";
        }

        public void logSerialText(String text)
        {
            logLine(text);
            text = text.TrimEnd().TrimStart();

            //enable buttons bc received data
            toggleCmdBtns(false);

            string[] pos = text.Split(',');
            string[] possHWP = { "0.00", "22.50", "45.00", "67.50" };
            string[] possLA = { "0", "1", "2" };

            if (text.Contains("V:"))
            {
                lblFwVers.Text = "Version: "+ text.Substring(3);
            }

            if (pos.Length == 4)
            {
                lastPos = text;
                pinStats = pos[3];


                this.vPos = Array.IndexOf(possHWP,pos[0]);
                this.iPos = Array.IndexOf(possHWP,pos[1]);
                this.trayPos = Array.IndexOf(possLA,pos[2]);

                switch (pos[0])
                {
                    case "0.00":
                        vPos0.Checked = true;
                        vPos1.Checked = false;
                        vPos2.Checked = false;
                        vPos3.Checked = false;
                        //if we're at zero and this limit isnt triggered... notify
                        if (pinStats.Substring(3, 1).Equals("0"))
                        {
                            vHWPgrp.BackColor = System.Drawing.Color.DarkSeaGreen;
                            lblVLIMITSWITCHPROB.Visible = false;
                        }
                        else
                        {
                            lblVLIMITSWITCHPROB.Visible = true;
                            vHWPgrp.BackColor = System.Drawing.Color.Firebrick;
                        }
                        break;
                    case "22.50":
                        vPos0.Checked = false;
                        vPos1.Checked = true;
                        vPos2.Checked = false;
                        vPos3.Checked = false;

                        vHWPgrp.BackColor = System.Drawing.SystemColors.Control;
                        break;
                    case "45.00":
                        vPos0.Checked = false;
                        vPos1.Checked = false;
                        vPos2.Checked = true;
                        vPos3.Checked = false;

                        vHWPgrp.BackColor = System.Drawing.SystemColors.Control;
                        break;
                    case "67.50":
                        vPos0.Checked = false;
                        vPos1.Checked = false;
                        vPos2.Checked = false;
                        vPos3.Checked = true;

                        vHWPgrp.BackColor = System.Drawing.SystemColors.Control;
                        break;
                    case "-2.00":
                        vPos0.Checked = false;
                        vPos1.Checked = false;
                        vPos2.Checked = false;
                        vPos3.Checked = false;

                        lblNOTHOMED.Visible = true;
                        lblVLIMITSWITCHPROB.Visible = true;
                        vHWPgrp.BackColor = System.Drawing.Color.IndianRed;

                        break;
                    default:
                        vPos0.Checked = false;
                        vPos1.Checked = false;
                        vPos2.Checked = false;
                        vPos3.Checked = false;
                        lblNOTHOMED.Visible = true;
                        vHWPgrp.BackColor = System.Drawing.Color.IndianRed;
                        break;

                }
                switch (pos[1])
                {

                    case "0.00":
                        iPos0.Checked = true;
                        iPos1.Checked = false;
                        iPos2.Checked = false;
                        iPos3.Checked = false;

                        //if we're at zero and this limit isnt triggered... notify
                        if (pinStats.Substring(4, 1).Equals("0"))
                        {
                            iHWPgrp.BackColor = System.Drawing.Color.DarkSeaGreen;
                            lblILIMITSWITCHPROB.Visible = false;
                        }
                        else
                        {
                            lblILIMITSWITCHPROB.Visible = true;
                            iHWPgrp.BackColor = System.Drawing.Color.Firebrick;
                        }
                        break;
                    case "22.50":
                        iPos0.Checked = false;
                        iPos1.Checked = true;
                        iPos2.Checked = false;
                        iPos3.Checked = false;

                        iHWPgrp.BackColor = System.Drawing.SystemColors.Control;
                        break;
                    case "45.00":
                        iPos0.Checked = false;
                        iPos1.Checked = false;
                        iPos2.Checked = true;
                        iPos3.Checked = false;

                        iHWPgrp.BackColor = System.Drawing.SystemColors.Control;
                        break;
                    case "67.50":
                        iPos0.Checked = false;
                        iPos1.Checked = false;
                        iPos2.Checked = false;
                        iPos3.Checked = true;

                        iHWPgrp.BackColor = System.Drawing.SystemColors.Control;
                        break;
                    case "-2.00":
                        iPos0.Checked = false;
                        iPos1.Checked = false;
                        iPos2.Checked = false;
                        iPos3.Checked = false;

                        lblNOTHOMED.Visible = true;
                        lblILIMITSWITCHPROB.Visible = true;
                        iHWPgrp.BackColor = System.Drawing.Color.IndianRed;

                        break;
                    default:
                        iPos0.Checked = false;
                        iPos1.Checked = false;
                        iPos2.Checked = false;
                        iPos3.Checked = false;

                        lblNOTHOMED.Visible = true;
                        iHWPgrp.BackColor = System.Drawing.Color.IndianRed;
                        break;
                }

                switch (pos[2])
                {
                    case "0":
                        vLight.Checked = true;
                        oLight.Checked = false;
                        iLight.Checked = false;
                        //if we're at position zero, the limit for zero should be triggered.
                        //check it
                        if (pinStats.Substring(0, 1).Equals("0"))
                        {
                            LAgrp.BackColor = System.Drawing.Color.DarkSeaGreen;
                            lblLLIMITSWITCHPROB.Visible = false;
                        }
                        else
                        {
                            lblLLIMITSWITCHPROB.Visible = true;
                            LAgrp.BackColor = System.Drawing.Color.Firebrick;
                        }
                        break;
                    case "1":
                        vLight.Checked = false;
                        oLight.Checked = true;
                        iLight.Checked = false;
                        //the limit for should be triggered.
                        //check it
                        if (pinStats.Substring(1, 1).Equals("0"))
                        {
                            LAgrp.BackColor = System.Drawing.Color.DarkSeaGreen;
                            lblLLIMITSWITCHPROB.Visible = false;
                        }
                        else
                        {
                            lblLLIMITSWITCHPROB.Visible = true;
                            LAgrp.BackColor = System.Drawing.Color.Firebrick;
                        }
                        break;
                    case "2":
                        vLight.Checked = false;
                        oLight.Checked = false;
                        iLight.Checked = true;
                        //the limit for should be triggered.
                        //check it
                        if (pinStats.Substring(2, 1).Equals("0"))
                        {
                            LAgrp.BackColor = System.Drawing.Color.DarkSeaGreen;
                            lblLLIMITSWITCHPROB.Visible = false;
                        }
                        else
                        {
                            lblLLIMITSWITCHPROB.Visible = true;
                            LAgrp.BackColor = System.Drawing.Color.Firebrick;
                        }
                        break;
                    case "-2":
                        vLight.Checked = false;
                        oLight.Checked = false;
                        iLight.Checked = false;

                        lblNOTHOMED.Visible = true;
                        lblLLIMITSWITCHPROB.Visible = true;
                        LAgrp.BackColor = System.Drawing.Color.IndianRed;
                        break;
                    default:
                        vLight.Checked = false;
                        oLight.Checked = false;
                        iLight.Checked = false;
                        lblNOTHOMED.Visible = true;
                        LAgrp.BackColor = System.Drawing.Color.IndianRed;
                        break;

                }

                if (possHWP.Contains(pos[0]) && possHWP.Contains(pos[1]) && possLA.Contains(pos[2]))
                {
                    lblNOTHOMED.Visible = false;
                }

            }
        }

        public void getStatus()
        {
            btnGetStatus_Click(this, new EventArgs());
        }
        //no button toggle bc instant return
        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            if (ser.IsOpen)
            {
                ser.Write("#" + delimChar);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ser.DataReceived -= new SerialDataReceivedEventHandler(receiveSer);
            ser.Close();
            logLine("Disconnected");
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;

            //hide all UI components
            toggleUI(true);
        }

        //send homing (checks if we're already homed...)
        private void btnHome_Click(object sender, EventArgs e)
        {

            if (ser.IsOpen)
            {
                if (!lastPos.Contains("-"))
                {
                    DialogResult dialogResult = MessageBox.Show("It looks like the motors are homed,\nDo you actually want to home again?",
                        "Already Home", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ser.Write("H" + delimChar);
                        //disable buttons while we wait
                        toggleCmdBtns(true);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Console.WriteLine("didn't send home...");
                    }
                }
                else
                {
                    ser.Write("H" + delimChar);
                    //disable buttons while we wait
                    toggleCmdBtns(true);
                }
            }
        }
        //send what's in the text field to the board via serial
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ser.IsOpen && tbToSend.Text != "")
            {
                ser.Write(tbToSend.Text + delimChar);
                tbToSend.Text = "";
            }
            //disable buttons while we wait
            toggleCmdBtns(true);
        }

        private void waitFor(ushort s)
        {
            Thread.Sleep(s);
        }

        //change lineup of motors/options
        private void cbMtr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMtrPos.Enabled = true;
            switch (cbMtr.Text)
            {
                case "V":
                    cbMtrPos.Items.Clear();
                    cbMtrPos.Items.Add("0");
                    cbMtrPos.Items.Add("22.5");
                    cbMtrPos.Items.Add("45");
                    cbMtrPos.Items.Add("67.5");
                    if (this.vPos > 0)
                    {
                        cbMtrPos.SelectedIndex = this.vPos;
                    }
                    else
                    {
                        cbMtrPos.SelectedIndex = 0;

                    }
                    break;
                case "L":
                    cbMtrPos.Items.Clear();
                    cbMtrPos.Items.Add("V-band");
                    cbMtrPos.Items.Add("Open");
                    cbMtrPos.Items.Add("I-band");

                    if (this.trayPos > 0)
                    {
                        cbMtrPos.SelectedIndex = this.trayPos;
                    }
                    else
                    {
                        cbMtrPos.SelectedIndex = 0;

                    }
                    break;
                case "I":
                    cbMtrPos.Items.Clear();
                    cbMtrPos.Items.Add("0");
                    cbMtrPos.Items.Add("22.5");
                    cbMtrPos.Items.Add("45");
                    cbMtrPos.Items.Add("67.5");

                    if (this.iPos > 0)
                    {
                        cbMtrPos.SelectedIndex = this.iPos;
                    }
                    else
                    {
                        cbMtrPos.SelectedIndex = 0;

                    }
                    break;
                default:
                    break;
            }

            cbMtrPos.Enabled = true;
            btnMoveMtr.Enabled = true;
        }
        //move the selected motor to the selected position
        private void btnMoveMtr_Click(object sender, EventArgs e)
        {
            moveCmd = cbMtr.Text + "=" + cbMtrPos.SelectedIndex;
            Console.WriteLine(moveCmd);
            if (ser.IsOpen)
            {
                ser.Write(moveCmd + delimChar);
            }
            //disable buttons while we wait
            toggleCmdBtns(true);
        }
        //uptime request (no disabling of buttons bc instant response)
        private void btnUptime_Click(object sender, EventArgs e)
        {
            if (ser.IsOpen)
            {
                ser.Write("U" + delimChar);
            }
        }
        //respond to enter as if it clicked btnSend
        private void tbToSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSend_Click(sender, e);
            }
        }
        //respond to enter as if it clicked btnConnect
        private void cbCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnConnect_Click(sender, e);
            }
        }
        //create about messagebox
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String about = "Manual Polarimetry v0.2"+Environment.NewLine; 
            about+="Written by Justin Moore"+Environment.NewLine;
            about+="Send Commands" + Environment.NewLine;
            about+="'?' Help message" + Environment.NewLine;
            about+="'S' Motor Statuses" + Environment.NewLine;
            about += "'@' Motor Statuses on a Single Line (csv style)" + Environment.NewLine;
            about += "'#' Motor Statuses on a Single Line with Limit Info (csv style)" + Environment.NewLine;
            about+="'H' Home all motors" + Environment.NewLine;
            about+="'R' Release the stepper motors (Solves build up of heat problem)" + Environment.NewLine;
            about+="'V' Arduino Firmware Version" + Environment.NewLine;
            about+="'U' Arduino Uptime" + Environment.NewLine;
            about+="'A=X' Move motor A to position X. " + Environment.NewLine;
            about += "\tA is within [V,I,L] " + Environment.NewLine;
            about += "\tX is within [0,1,2] for LA " + Environment.NewLine;
            about += "\tX is within [0,1,2,3] for HWP's" + Environment.NewLine;
            about+="'L=3,X' Move LA tray right for X ms" + Environment.NewLine;
            about += "'L=4,X' Move LA tray left for X ms" + Environment.NewLine;
            MessageBox.Show(about);

        }
        //create ability to close out from the file menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ser.IsOpen){
                ser.Close();
            }
            System.Windows.Forms.Application.Exit();
        }

        //enable or disable communication buttons to prevent double sending
        private void toggleCmdBtns(bool active)
        {
            //want to disable
            if (active) 
            {
                btnGetStatus.Enabled = false;
                btnMoveMtr.Enabled = false;
                btnSend.Enabled = false;
                btnUptime.Enabled = false;
                btnHome.Enabled = false;
                cbMtr.Enabled = false;
                cbMtrPos.Enabled = false;
                tbToSend.Enabled = false;
            }
            //enable
            else
            {
                btnGetStatus.Enabled = true;
                btnMoveMtr.Enabled = true;
                btnSend.Enabled = true;
                btnUptime.Enabled = true;
                btnHome.Enabled = true;
                cbMtr.Enabled = true;
                if (cbMtr.SelectedIndex >= 0)
                {
                    cbMtrPos.Enabled = true;
                }
                tbToSend.Enabled = true;
                tbToSend.Focus();
            }
        }

        private void toggleUI(bool change)
        {
            if (change)
            {
                lblNOTHOMED.Visible = false;
                vHWPgrp.Visible = false;
                iHWPgrp.Visible = false;
                LAgrp.Visible = false;

                tbLog.Visible = false;
                tbToSend.Visible = false;
                btnSend.Visible = false;
                btnHome.Visible = false;
                btnGetStatus.Visible = false;
                lblMtr.Visible = false;
                lblMtrPos.Visible = false;
                cbMtr.Visible = false;
                cbMtrPos.Visible = false;
                btnMoveMtr.Visible = false;
                lblFwVers.Visible = false;
                btnUptime.Visible = false;
                lblVLIMITSWITCHPROB.Visible = false;
                lblILIMITSWITCHPROB.Visible = false;
                lblLLIMITSWITCHPROB.Visible = false;
            }
            else
            {
                lblNOTHOMED.Visible = true;
                vHWPgrp.Visible = true;
                iHWPgrp.Visible = true;
                LAgrp.Visible = true;

                tbLog.Visible = true;
                tbToSend.Visible = true;
                btnSend.Visible = true;
                btnHome.Visible = true;
                btnGetStatus.Visible = true;
                lblMtr.Visible = true;
                lblMtrPos.Visible = true;
                cbMtr.Visible = true;
                cbMtrPos.Visible = true;
                btnMoveMtr.Visible = true;
                lblFwVers.Visible = true;
                btnUptime.Visible = true;
            }
        }
    }
}
