using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace APK_Manager
{
    public partial class AndroidRemote : Form
    {
        private ShellAPI shell;
        public AndroidRemote()
        {
            InitializeComponent();
            shell = new ShellAPI();
        }

        private void AndroidRemote_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_DPAD_RIGHT");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_DPAD_UP");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_DPAD_CENTER");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_DPAD_LEFT");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_DPAD_DOWN");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_BACK");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell input keyevent KEYCODE_HOME");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell am start -a android.settings.AIRPLANE_MODE_SETTINGS");
            Thread.Sleep(1000);
            shell.Execute("adb shell input keyevent 19");
            Thread.Sleep(1000);
            shell.Execute("adb shell input keyevent 23");
            Thread.Sleep(1000);
            shell.Execute("adb shell input keyevent KEYCODE_HOME");
            Thread.Sleep(1000);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            shell.Execute("adb shell am start -a android.intent.action.MAIN -n com.android.settings/.wifi.WifiSettings");
            Thread.Sleep(1000);
            shell.Execute("adb shell input keyevent 19");
            Thread.Sleep(1000);
            shell.Execute("adb shell input keyevent 23");
            Thread.Sleep(1000);
            shell.Execute("adb shell input keyevent KEYCODE_HOME");
            Thread.Sleep(1000);
        }
    }
}
