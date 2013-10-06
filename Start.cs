using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace APK_Manager
{
    public partial class Start : Form
    {
        //global - holds the current active device serial
        public string activeDevice;
        //global - list of connected devices
        public string activeDeviceStatus = string.Empty;
        //global - apk file location
        public string strFileName = string.Empty;
        //global - active device type
        public string activeDeviceType = "None";
        //global - execution result
        public string result;
        

        //This method recieves a shell command and returns it's result as a string by calling the shellAPI class.
        public string ExecuteShellCommand(string command)
        {
            UpdateControls(false);
            string result = null;
            ShellAPI shell = new ShellAPI(this);

            //no threadding shell command
            //ShellAPI shell = new ShellAPI(this);
            //return shell.Execute(command);

            //Threadded solution
            Thread execute = new Thread(
                () =>
                {
                   result = shell.Execute(command);
                   
                });
            execute.Start();
            //blocking call, waiting for the thread to terminate
            execute.Join();
            UpdateControls(true);
            return result;
                                 
        }

        //This method recieves a shell command and executes it without waiting for response.
        public string ExecuteShellCommandAsync(string command)
        {
            string result = null;
            ShellAPI shell = new ShellAPI(this);

            //no threadding shell command
            //ShellAPI shell = new ShellAPI(this);
            //return shell.Execute(command);

            //Threadded solution
            Thread execute = new Thread(
                () =>
                {
                    result = shell.Execute(command);

                });
            execute.Start();
            //no blocking call, main thread continues.
            //execute.Join();
            return result;

        }

        //This method returns an array of connected devices parsed from shell and their status
        //If no device is attached, null is returned.
        //Even places contain serials. Odd places contain device status.
        public ArrayList GetConnectedDevices()
        {
          ArrayList devices = new ArrayList();
          //get devices
          string cmdRes = ExecuteShellCommand("adb devices");
          
          // no device attached - return null
          if (cmdRes.Equals("List of devices attached \r\n\r\n"))
          {
              UpdateControls(false);
              return null;
          }
          else
          {
              string[] tempLines = Regex.Split(cmdRes, "\r\n|\r|\n|\t");
              foreach (string s in tempLines) devices.Add(s);
              //remove first line (devices)
              devices.RemoveAt(0);
              // remove empty lines
              for (int i = 0; i < devices.Count; i++)
                  if (devices[i].Equals(""))
                  {
                      devices.Remove(devices[i]);
                      i = 0;
                  }
              UpdateControls(true);
              return devices;
          }     
           
        }
        //This method recieves a device serial, checks it's status and updated the 'status' box
        private void SetDeviceStatus(string deviceSerial)
        {
            deviceStatusTextBox.Text = "Device Status";
            activeDeviceStatus = "No active device";
            ArrayList devices = GetConnectedDevices();

            if (devices != null)
            {
                for (int i = 0; i < devices.Count; i++)
                {
                    if (devices[i].ToString().Equals(deviceSerial))
                    {
                        activeDeviceStatus = devices[i + 1].ToString();
                    }
                }
            }

            deviceStatusTextBox.Text = activeDeviceStatus;
            return;

         }
        //This method prints a line to the log.
        public void Log(string input)
        {
            listBox1.Items.Add(input);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = -1;
        }
        //This method cleans a string from escape characters
        private string CleanString(string input)
        {
        string[] charsToRemove = new string[] { "/n", "/r"};
        foreach (string c in charsToRemove)
            {
            input = input.Replace(c, string.Empty);
            }
        return input;
        }
        //This method gets active device type
        private string GetActiveDeviceType()
        {
            string getTypeString = "adb -s " + activeDevice + " shell getprop ro.product.model";
            string type = CleanString(ExecuteShellCommand(getTypeString));
            if (type.Contains("error"))
                return "Error! Device unavailable.";
            else
             return(type);
        }
        
        //This method enables/disables all controls on the program
        public void UpdateControls(bool ctrlStat)
        {
            if (ctrlStat)
            {
                openApkBtn.Enabled = true;
                install.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;

            }
            else
            {
                openApkBtn.Enabled = false;
                install.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
            }
            
        }

        
        public Start()
        {
            InitializeComponent();
            UpdateControls(false);
            FillDevices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDevices();
  
        }

        //This methos fills the combo box with the connected devices
        public void FillDevices()
        {
            //debug info into text box
            Log("adb response");
            Log(ExecuteShellCommand("adb devices"));
            
            //propogate combo box with devices.
            devicesComboBox.Enabled = true;
            devicesComboBox.Items.Clear();
            devicesComboBox.Text = "";
            //No device connected
            if (GetConnectedDevices() == null)
            {
                Log("No adb devices detected");
                devicesComboBox.Enabled = false;
                label4.Text = "None";
                
            }
            else
            {
                ArrayList devices = GetConnectedDevices();
                //fill the combobox with connected devices
                for (int i = 0; i < devices.Count; i+=2)
                {
                    devicesComboBox.Items.Add(devices[i]);
                   
                }
                try
                {
                    devicesComboBox.SelectedIndex = 0;
                }
                catch (Exception e)
                {
                    Log(e.Message);
                    ClearDevices();
                }

                activeDevice = devicesComboBox.GetItemText(devicesComboBox.SelectedItem);
                
                
            }

            SetDeviceStatus(activeDevice);
            return;
            
        }

        private void Devices_SelectedValueChanged(object sender, EventArgs e)
        {
            activeDevice = devicesComboBox.GetItemText(devicesComboBox.SelectedItem);
            SetDeviceStatus(activeDevice);
            activeDeviceType = GetActiveDeviceType();
            label4.Text = activeDeviceType;

        }

        private void deviceStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (deviceStatusTextBox.Text.Equals("device"))
            {
                deviceStatusTextBox.BackColor = System.Drawing.Color.Green;
                UpdateControls(true);
            }
            else if (deviceStatusTextBox.Text.Equals("offline"))
            {
                deviceStatusTextBox.BackColor = System.Drawing.Color.Red;
                UpdateControls(false);
            }
            else
            {
                deviceStatusTextBox.BackColor = System.Drawing.Color.DimGray;
                UpdateControls(false);

            }
        }

        //select the apk to install
        private void openApkBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "APK files (*.apk)|*.apk";
            dialog.InitialDirectory = "C:\\ProgramData\\ITE\\Test Content\\Test Libraries\\AndroidLib\\Tools\\AndroidExecutionApp";
            dialog.Title = "Select the apk to install";
            if (dialog.ShowDialog() == DialogResult.OK)
                strFileName = dialog.FileName;
            if (strFileName == String.Empty)
                return;
            //add double quotes.
            strFileName = (char)34 + strFileName + (char)34;
            Log("APK file selected. Path is: ");
            Log(strFileName);
            Log(" Press install to install");
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcpADB enterIP = new tcpADB(this);
            enterIP.Show();
        }

        private void install_Click_1(object sender, EventArgs e)
        {

            string type = GetActiveDeviceType();

            if (strFileName.Equals(String.Empty))
                Log("No APK selected" + Environment.NewLine);
            else
            {
                if (type.Contains("6410") || type.Contains("6430"))
                    Install.InstallDell(activeDevice, this);
                else if (type.Contains("XMM"))
                    Install.InstallXMM(activeDevice, this);
                else if (type.Contains("Nexus 4") || type.Contains("Nexus 7") || type.Contains("saltbay"))
                    Install.InstallNexus4(activeDevice, this);
                else Log("Device Not Supported");
                        
            }

                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log(ExecuteShellCommand("adb disconnect " + activeDevice));
            Log(activeDevice + " Disconnected");
            FillDevices();
        }

        //uninstall the apk, depending on the platform
        private void button4_Click(object sender, EventArgs e)
        {

            string type = GetActiveDeviceType();

                if (type.Contains("6410") || type.Contains("6430"))
                {
                Log("This might take some time...");
                Log(ExecuteShellCommand("adb -s " + activeDevice + " uninstall com.intel.mwg"));
                Log(ExecuteShellCommand("adb -s " + activeDevice + " shell rm /system/app/mwgActivity-release.apk"));
                Log(ExecuteShellCommand("adb -s " + activeDevice + " shell rm /system/app/com.intel.mwg.apk"));
                }
                else
                {
                Log("Attempting to mount /system as r/w");
                Log("This might take some time...");
                Log(ExecuteShellCommand("adb -s " + activeDevice + " shell su -c mount -wo remount /system"));
                Log(ExecuteShellCommand("adb -s " + activeDevice + " uninstall com.intel.mwg"));
                Log(ExecuteShellCommand("adb -s " + activeDevice + " shell su -c rm /system/app/mwgActivity-release.apk"));
                Log(ExecuteShellCommand("adb -s " + activeDevice + " shell su -c rm /system/app/com.intel.mwg.apk"));
                Log("Attempted removal from known locations and file names");
                Log("If not sure, Please check manually");
                }
                                             

         }

        private void button5_Click(object sender, EventArgs e)
        {
            if (strFileName.Equals(String.Empty))
                Log("No APK selected" + Environment.NewLine);
            else
            {
                string message = "Warning - This will not install the app as root, preventing access to aiplane mode, reboot etc. \n Do you want to continue?";

                DialogResult dr = MessageBox.Show(message, "warning", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                    Install.InstallNotSysapp(activeDevice, this);
                else
                    return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //this method installs adb on the machine.
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string adbDir = @"C:/ADB/";
                if (!(Directory.Exists(adbDir)))
                {
                    Directory.CreateDirectory(adbDir);
                    Log(@"C:/ADB/ Directory created successfully");
                    
                    File.WriteAllBytes(adbDir + "adb.exe", Properties.Resources.adb);
                    File.WriteAllBytes(adbDir + "AdbWinApi.dll", Properties.Resources.AdbWinApi);
                    File.WriteAllBytes(adbDir + "AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
                    Log("ADB installed successfully");
                    
                    string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine) + ";" + adbDir + ";";
                    Environment.SetEnvironmentVariable("Path", path, EnvironmentVariableTarget.Machine);
                    Log(@"Added C:/ADB to enviroment variable Path");
                    
                }
                else
                {
                    Log(@"ADB is already installed. Please delete C:/ADB/ if you want to re install");

                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            
        }

        //Iperf installation
        private void button9_Click(object sender, EventArgs e)
        {
            if (activeDeviceType.Contains("XMM"))
                Install.InstallIperfXMM(activeDevice, this);
            else if (GetActiveDeviceType().Contains("Nexus 4") || GetActiveDeviceType().Contains("Nexus 7"))
                Install.InstallIperfNexus(activeDevice, this);
            else
                Log("Device not supported!");




        }

        // clears the devices list box
        public void ClearDevices()
        {
            devicesComboBox.Items.Clear();
            UpdateControls(false);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Log("Command sent");
            Log("adb -s " + activeDevice + " shell input keyevent 26");
            ExecuteShellCommandAsync("adb -s " + activeDevice + " shell input keyevent 26");
            Log("Wake command sent to device");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (activeDeviceType.Contains("XMM"))
            {
                Log("Command sent");
                Log("adb -s " + activeDevice + " shell " + (char)34 + "echo 0 > /sys/devices/system/cpu/cpu1/online" + (char)34);
                ExecuteShellCommandAsync("adb -s " + activeDevice + " shell " + (char)34 + "echo 0 > /sys/devices/system/cpu/cpu1/online" + (char)34);
                Log("Changed to single core");
            }
            else
                Log("Device not supported!");
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ADB adb = new ADB(this);
            adb.Show();
        }

        // Restarts the adb daemon
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new Action(() => {this.UpdateControls(false);}));
            ExecuteShellCommandAsync("adb kill-server");
            this.listBox1.Invoke(new Action(() => { listBox1.Items.Add("Adb server killed"); }));
            ExecuteShellCommandAsync("adb start-server");
            this.listBox1.Invoke(new Action(() => { listBox1.Items.Add("Waiting 5 seconds for server to start"); }));
            System.Threading.Thread.Sleep(5000);
            this.listBox1.Invoke(new Action(() => { listBox1.Items.Add("Server started"); }));
            this.Invoke(new Action(() => { this.FillDevices(); }));
            this.Invoke(new Action(() => { this.UpdateControls(true); }));
            this.listBox1.Invoke(new Action(() => { listBox1.Items.Add("ADB restarted"); }));
            
        }

        



        }
}
        
