﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace APK_Manager
{
    class ShellAPI
    {
        //global - adb timeout in miliseconds
        int adb_timeout = 5000;

        //this methos handles the actual sending of the command to shell
        public string Execute(string command)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            p.StartInfo = startInfo;

            p.Start();

            string adbResponse = p.StandardOutput.ReadToEnd();
            adbResponse += p.StandardError.ReadToEnd();

            if (!p.WaitForExit(adb_timeout))
            {                
                return string.Empty;
            }
            else
            {                
                return adbResponse;
            }


        }




    }
}
