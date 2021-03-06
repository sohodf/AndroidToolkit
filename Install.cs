﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APK_Manager;
using System.IO;

namespace APK_Manager
{
    class Install
    {
        
        //This method installs the apk to dell platforms.
        public static void InstallDell(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            main.Log("Trying to push APK");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push " + main.strFileName + " /system/app/"));
            main.Log("APK installation finished. Please check device");
        }
        
        //this method installls the apk to XMM6321
        public static void InstallXMM(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            main.Log("Trying to mount system as r/w");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c mount -wo remount /system"));
            main.Log("Trying to push APK");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push " + main.strFileName + " /system/app/"));
            main.Log("APK installation finished. Please check device");

        }

        //this method installs the app as not sysapp
        public static void InstallNotSysapp(string ip, Start main)
        {
            main.Log("Using adb install...");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " install -r " + main.strFileName));
        }

        //this method installls the apk to Nexus4 Device
        public static void InstallNexus4(string ip, Start main)
        {
            //getting file name from path
            string path = main.strFileName;
            path = path.Replace("\"", "");
            string file = Path.GetFileName(path);
            main.Log("File name is: " + file);
           
            //installation
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            main.Log("Trying to mount system as r/w");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c mount -wo remount /system"));
            main.Log("Trying to push APK");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push " + main.strFileName + " /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c cp /sdcard/" + file + " /system/app/"));
            main.Log("APK installation finished. Please check device");
            main.Log("If installation failed, please make sure you are root");

        }

        //this method installls the apk to Nexus4 Device
        public static void InstallNexus4KK(string ip, Start main)
        {
            //getting file name from path
            string path = main.strFileName;
            path = path.Replace("\"", "");
            string file = Path.GetFileName(path);
            main.Log("File name is: " + file);

            //installation
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            main.Log("Trying to mount system as r/w");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + (char)34 + "mount -wo remount /system" + (char)34));
            main.Log("Trying to push APK");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push " + main.strFileName + " /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + (char)34 + "cp /sdcard/" + file + " /system/priv-app/" + (char)34));
            main.Log("APK installation finished. Please check device");
            main.Log("If installation failed, please make sure you are root");

        }


        //this method installls the apk to hsb Device
        public static void InstallHSB(string ip, Start main)
        {
            //getting file name from path
            string path = main.strFileName;
            path = path.Replace("\"", "");
            string file = Path.GetFileName(path);
            main.Log("File name is: " + file);

            //installation
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            main.Log("Trying to push APK");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push " + main.strFileName + " /sdcard/"));
            main.Log("Copying app to sdcard");
            main.Log("adb -s " + ip + " shell cp /sdcard/" + file + " /system/priv-app/");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell cp /sdcard/" + file + " /system/priv-app/"));
            main.Log("APK installation finished. Please check device");
            main.Log("If installation failed, please make sure you are root");

        }

        //this method installs iperf on XMM platfrom
        public static void InstallIperfXMM(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            string iperfDir = @"C:/";
            File.WriteAllBytes(iperfDir + "iperf", Properties.Resources.iperfARM);
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c mount -wo remount /system"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push c:/iperf /system/bin/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c chmod 777 /system/bin/iperf"));
            main.Log("Iperf for ARM installed");
            main.Log("Delete local iperf file");
            if (File.Exists(@"C:\iperf"))
            {
                File.Delete(@"C:\iperf");
                main.Log("Local iperf file deleted");
                return;
            }
            main.Log("Local iperf file not deleted");
        }

        //this method installs iperf on Nexus platfrom
        public static void InstallIperfNexus(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            string iperfDir = @"C:/";
            File.WriteAllBytes(iperfDir + "iperf", Properties.Resources.iperfARM);
            main.Log("Trying to mount system as r/w");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c mount -wo remount /system"));
            main.Log("Trying to push iperf");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push c:/iperf /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c cp /sdcard/iperf /system/bin"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c chmod 777 /system/bin/iperf"));
            main.Log("Iperf for ARM installed");
            main.Log("Delete local iperf file");
            if (File.Exists(@"C:\iperf"))
            {
                File.Delete(@"C:\iperf");
                main.Log("Local iperf file deleted");
                return;
            }
            main.Log("Local iperf file not deleted");
        }

        
        //this method installs iperf on HsB Platform 
        public static void InstallIperfHsB(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            string iperfDir = @"C:/";
            File.WriteAllBytes(iperfDir + "iperf", Properties.Resources.iperfX86);
            main.Log("Trying to mount system as r/w");
            main.Log("adb -s " + ip + " shell su -c " + (char)34 + "mount -wo remount /system" + (char)34);
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + (char)34 + "mount -wo remount /system" + (char)34));
            main.Log("Trying to push iperf");
            main.Log(("adb -s " + ip + " push c:\\iperf /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push c:\\iperf /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + (char)34 + "cp /sdcard/iperf /system/bin/" + (char)34));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + (char)34 + "cp /sdcard/iperf /system/bin/" + (char)34));
            main.Log(("adb -s " + ip + " shell su -c cp /sdcard/iperf /system/bin/"));
            main.Log(("adb -s " + ip + " shell su -c " + (char)34 + "chmod 777 /system/bin/iperf"+ (char)34));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + (char)34 + "chmod 777 /system/bin/iperf" + (char)34));
            main.Log("Iperf for X86 installed");
            main.Log("Delete local iperf file");
            if (File.Exists(@"C:\iperf"))
            {
                File.Delete(@"C:\iperf");
                main.Log("Local iperf file deleted");
                return;
            }
            main.Log("Local iperf file not deleted");
        }

        //this method installs iperf on HsB Platform 
        public static void InstallIperfSofia(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            string iperfDir = @"C:/";
            File.WriteAllBytes(iperfDir + "iperf", Properties.Resources.iperfX86);
            main.Log("Trying to mount system as r/w");
            main.Log("adb -s " + ip + " shell su -c " + "mount -wo remount /system");
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + "mount -wo remount /system"));
            main.Log("Trying to push iperf");
            main.Log(("adb -s " + ip + " push c:\\iperf /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push c:\\iperf /sdcard/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + "cp /sdcard/iperf /system/bin/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + "cp /sdcard/iperf /system/bin/"));
            main.Log(("adb -s " + ip + " shell su -c cp /sdcard/iperf /system/bin/"));
            main.Log(("adb -s " + ip + " shell su -c " + "chmod 777 /system/bin/iperf"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell su -c " + "chmod 777 /system/bin/iperf"));
            main.Log("Iperf for X86 installed");
            main.Log("Delete local iperf file");
            if (File.Exists(@"C:\iperf"))
            {
                File.Delete(@"C:\iperf");
                main.Log("Local iperf file deleted");
                return;
            }
            main.Log("Local iperf file not deleted");
        }

        //this method installs iperf on lollipop os. should be used as generic install for x86 platforms without su.
        public static void InstallIperfLP(string ip, Start main)
        {
            main.Log("Device selected: " + main.activeDeviceType + "@" + ip);
            string iperfDir = @"C:/";
            File.WriteAllBytes(iperfDir + "iperf", Properties.Resources.iperfX86);
            main.Log("Trying to mount system as r/w");
            main.Log("adb root");
            main.Log("adb remount");
            main.Log(main.ExecuteShellCommand("adb root"));
            main.Log(main.ExecuteShellCommand("adb remount"));
            main.Log("Trying to push iperf");
            main.Log(("adb -s " + ip + " push c:\\iperf /system/bin/"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " push c:\\iperf /system/bin/"));
            main.Log(("adb -s " + ip + " shell chmod 777 /system/bin/iperf"));
            main.Log(main.ExecuteShellCommand("adb -s " + ip + " shell chmod 777 /system/bin/iperf"));
            main.Log("Iperf for X86 installed");
            //main.Log("Please note that iperf is not PIE compatible, and it WILL NOT run on PIE enabled images");
            main.Log("Delete local iperf file");
            if (File.Exists(@"C:\iperf"))
            {
                File.Delete(@"C:\iperf");
                main.Log("Local iperf file deleted");
                return;
            }
            main.Log("Local iperf file not deleted");
        }

        //this method installs adb on the controller machine
        public static void InstallADB(Start main)
        {
            try
            {
                string adbDir = @"C:\ADB\";
                if (!(Directory.Exists(adbDir)))
                {
                    Directory.CreateDirectory(adbDir);
                    main.Log(@"C:\ADB\ Directory created successfully");

                    File.WriteAllBytes(adbDir + "adb.exe", Properties.Resources.adb);
                    File.WriteAllBytes(adbDir + "AdbWinApi.dll", Properties.Resources.AdbWinApi);
                    File.WriteAllBytes(adbDir + "AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
                    main.Log("ADB installed successfully");

                    string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine) + ";" + adbDir + ";";
                    Environment.SetEnvironmentVariable("Path", path, EnvironmentVariableTarget.Machine);
                    main.Log(@"Added C:\ADB to enviroment variable Path");

                }
                else
                {
                    main.Log(@"ADB is already installed. Please delete C:\ADB\ if you want to re install");

                }
            }
            catch (Exception ex)
            {
                main.Log(ex.Message);
            }
        }




    }
}
