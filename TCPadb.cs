﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace APK_Manager
{
    public partial class tcpADB : Form
    {
        public Start mw;
        
        public tcpADB(Start mw)
        {
            InitializeComponent();
            this.mw = mw;
            textBox1.Select();
            
        }

        private void tcpADB_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string ip = textBox1.Text;
            if (ip == "")
                MessageBox.Show("No IP entered");
            else
            {
                ip += ":5555";
                mw.Log("Trying to connect");
                mw.Log(mw.ExecuteShellCommand("adb connect " + ip));
                ArrayList devices = mw.GetConnectedDevices();

                foreach (string device in devices)
                    if (device.Equals(ip))
                    {
                        mw.Log("Device " + ip + " connected");
                        mw.FillDevices();
                        mw.devicesComboBox.SelectedItem = ip;
                        flag = true;
                        break;
                    }
                
                if (!flag)
                    MessageBox.Show("Failed to connect to device");

                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
