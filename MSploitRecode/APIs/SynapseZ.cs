﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSploitRecode.APIs
{
    // WARNING - This is edited, not the original API code.


    public struct SynapseZLaunchData
    {
        public string Version;
        public string InjectorName;
        public string DllName;
    }

    public class SynapseZ
    {
        private string LatestErrorMsg = "";
        public string FolderPath;

        public SynapseZ(string FolderPath) {
            this.FolderPath = FolderPath;

            if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);
        }

        /**
         * Return values:
         * not-empty string -> Path to the launcher
         * empty string -> Couldn't find the launcher
        */
        public string FindLauncher()
        {
            if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);

            foreach (var file in Directory.GetFiles(FolderPath))
            {
                string content = File.ReadAllText(file);
                if (content.Contains(".grh0") && content.Contains(".grh1") && content.Contains(".grh2"))
                {
                    return file;
                }
            }

            return String.Empty;
        }

        /**
         * Return values:
         * 0 - Injection successful
         * 1 - MainPath is not a valid Directory
         * 2 - launcher not found
         * 3 - Couldn't start the launcher
        */
        public int Inject()
        {
            if (!Directory.Exists(FolderPath))
            {
                LatestErrorMsg = "FolderPath doesnt lead to a directory.";
                return 1;
            }

            string LauncherPath = FindLauncher();

            if (LauncherPath == String.Empty)
            {
                LatestErrorMsg = "Could not find the Launcher!";
                return 2;
            }

            Process process = new Process();
            process.StartInfo.FileName = LauncherPath;
            process.StartInfo.WorkingDirectory = FolderPath;

            try
            {
                process.Start();
                return 0;
            }
            catch (Exception e)
            {
                LatestErrorMsg = e.Message;
                return 3;
            }
        }

        /**
         * Return values:
         * 0 - Injection successful
         * 1 - MainPath is not a valid Directory
         * 2 - launcher not found
         * 3 - Couldn't start the launcher
        */
        public int Redeem()
        {
            if (!Directory.Exists(FolderPath))
            {
                LatestErrorMsg = "FolderPath doesnt lead to a directory.";
                return 1;
            }

            string LauncherPath = FindLauncher();

            if (LauncherPath == String.Empty)
            {
                LatestErrorMsg = "Could not find the Launcher!";
                return 2;
            }

            Process process = new Process();
            process.StartInfo.FileName = LauncherPath;
            process.StartInfo.Arguments = "redeem";
            process.StartInfo.WorkingDirectory = FolderPath;

            try
            {
                process.Start();
                return 0;
            }
            catch (Exception e)
            {
                LatestErrorMsg = e.Message;
                return 3;
            }
        }

        /**
         * Return values:
         * 0 - Injection successful
         * 1 - MainPath is not a valid Directory
         * 2 - launcher not found
         * 3 - Couldn't start the launcher
        */
        public int Info()
        {
            if (!Directory.Exists(FolderPath))
            {
                LatestErrorMsg = "FolderPath doesnt lead to a directory.";
                return 1;
            }

            string LauncherPath = FindLauncher();

            if (LauncherPath == String.Empty)
            {
                LatestErrorMsg = "Could not find the Launcher!";
                return 2;
            }

            Process process = new Process();
            process.StartInfo.FileName = LauncherPath;
            process.StartInfo.Arguments = "info";
            process.StartInfo.WorkingDirectory = FolderPath;

            try
            {
                process.Start();
                return 0;
            }
            catch (Exception e)
            {
                LatestErrorMsg = e.Message;
                return 3;
            }
        }

        /**
         * Return values:
         * 0 - Injection successful
         * 1 - MainPath is not a valid Directory
         * 2 - launcher not found
         * 3 - Couldn't start the launcher
        */
        public int ResetHwid()
        {
            if (!Directory.Exists(FolderPath))
            {
                LatestErrorMsg = "FolderPath doesnt lead to a directory.";
                return 1;
            }

            string LauncherPath = FindLauncher();

            if (LauncherPath == String.Empty)
            {
                LatestErrorMsg = "Could not find the Launcher!";
                return 2;
            }

            Process process = new Process();
            process.StartInfo.FileName = LauncherPath;
            process.StartInfo.Arguments = "resethwid";
            process.StartInfo.WorkingDirectory = FolderPath;

            try
            {
                process.Start();
                return 0;
            }
            catch (Exception e)
            {
                LatestErrorMsg = e.Message;
                return 3;
            }
        }


        /**
         * Returns the latest error message from any action.
        */
        public string GetLatestErrorMessage()
        {
            return LatestErrorMsg;
        }

        /**
         * Return values:
         * 0 - Execution successful
         * 1 - MainPath is not a valid Directory
         * 2 - Bin Folder not found
         * 3 - Scheduler Folder not found
         * 4 - No access to write file
        */
        public int Execute(string Script, int PID = 0)
        {
            if (!Directory.Exists(FolderPath))
            {
                LatestErrorMsg = "FolderPath doesnt lead to a directory.";
                return 1;
            }

            string BinPath = Path.Combine(FolderPath, "bin");

            if (!Directory.Exists(BinPath))
            {
                LatestErrorMsg = "Could not find the Bin Folder!";
                return 2;
            }

            string SchedulerPath = Path.Combine(BinPath, "scheduler");

            if (!Directory.Exists(SchedulerPath))
            {
                LatestErrorMsg = "Could not find the Scheduler Folder!";
                return 3;
            }

            string RandomFileName = RandomString(10) + ".lua";
            string FilePath = PID == 0 ? Path.Combine(SchedulerPath, RandomFileName) : Path.Combine(SchedulerPath, "PID" + PID + "_" + RandomFileName);

            try
            {
                File.WriteAllText(FilePath, Script + "@@FileFullyWritten@@");
            }
            catch (Exception e)
            {
                LatestErrorMsg = e.Message;
                return 4;
            }

            return 0;
        }

        /**
         * Return values:
         * null - MainPath is not a valid Directory
         * null - Bin Folder not found
         * null - launch.syn not found
         * null - No access to read file
         * SynapseZLaunchData - Data Found
        */
        public Nullable<SynapseZLaunchData> GetLaunchData()
        {
            if (!Directory.Exists(FolderPath))
            {
                LatestErrorMsg = "FolderPath is not a valid Directory";
                return null;
            }

            string BinPath = Path.Combine(FolderPath, "bin");

            if (!Directory.Exists(BinPath))
            {
                LatestErrorMsg = "Bin Folder not found";
                return null;
            }

            string LaunchSynPath = Path.Combine(BinPath, "launch.syn");

            if (!File.Exists(LaunchSynPath))
            {
                LatestErrorMsg = "launch.syn not found";
                return null;
            }

            try
            {
                string content = File.ReadAllText(LaunchSynPath);
                SynapseZLaunchData data = new SynapseZLaunchData();
                data.Version = content.Substring(0, 24);
                data.InjectorName = content.Substring(24, 20);
                data.DllName = content.Substring(44, 12);

                LatestErrorMsg = "";

                return data;
            }
            catch (Exception e)
            {
                LatestErrorMsg = e.Message;
                return null;
            }
        }

        /**
         * Return values:
         * System.Diagnostics.Process[] - Roblox Processes
        */
        public System.Diagnostics.Process[] GetRobloxProcesses()
        {
            return Process.GetProcessesByName("RobloxPlayerBeta");
        }

        /**
         * Return values:
         * List<Process> - Injected Processes
        */
        public List<Process> GetInjectedRobloxProcesses()
        {
            Nullable<SynapseZLaunchData> data = GetLaunchData();
            if (data == null) return new List<Process>();
            SynapseZLaunchData zLaunchData = (SynapseZLaunchData)data;

            Process[] processes = GetRobloxProcesses();
            List<Process> injectedProcesses = new List<Process>();

            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];

                foreach (ProcessModule module in process.Modules)
                {
                    if (module.ModuleName == zLaunchData.DllName)
                    {
                        injectedProcesses.Add(process);
                    }
                }
            }

            return injectedProcesses;
        }

        public List<Process> GetInjectedRobloxProcesses(SynapseZLaunchData data)
        {
            Process[] processes = GetRobloxProcesses();
            List<Process> injectedProcesses = new List<Process>();

            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];

                foreach (ProcessModule module in process.Modules)
                {
                    if (module.ModuleName == data.DllName)
                    {
                        injectedProcesses.Add(process);
                    }
                }
            }

            return injectedProcesses;
        }

        /**
            * Return values:
            * null - GetLaunchData() failed
            * bool - Injected or not
        */
        public Nullable<bool> IsInjected(int PID = 0)
        {
            Nullable<SynapseZLaunchData> data = GetLaunchData();
            if (!data.HasValue)
            {
                return null;
            }

            List<Process> injectedProcesses = GetInjectedRobloxProcesses(data.Value);

            if (PID != 0)
            {
                return injectedProcesses.Exists((process) => process.Id == PID);
            }
            else
            {
                return injectedProcesses.Count != 0;
            }
        }

        /**
            * Return values:
            * null - GetLaunchData() failed
            * bool - Injected or not
        */
        public Nullable<bool> IsInjectedIntoAllInstances()
        {
            if (GetRobloxProcesses().Length == 0) return false;

            Nullable<SynapseZLaunchData> data = GetLaunchData();
            if (!data.HasValue)
            {
                return null;
            }

            return GetInjectedRobloxProcesses(data.Value).Count == GetRobloxProcesses().Length;
        }

        /**
         * Yeah you can ignore everything after this part
        */
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
