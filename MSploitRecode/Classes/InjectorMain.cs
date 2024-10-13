using MSploitRecode.APIs;
using SeliwareAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Classes
{
    public struct WrapperData
    {
        public string API;

        public bool IsInjected;
        public bool RobloxRunning;
    }

    internal class InjectorMain
    {
        public static SynapseZ synapseZ = new SynapseZ(Path.Combine(Data.ExecutorsFolder, "SynapseZ"));

        // Variables //
        public static bool Injecting { get; set; }

        private static bool Setupped = false;
        public void Setup()
        {
            if (Setupped) return;
            Setupped = true;

            Seliware.Injected += delegate
            {
                // maybe //
            };
        }

        // Functions //
        public static WrapperData GetData()
        {
            bool IsInjected = false;
            bool RobloxRunning = false;

            // Check Roblox //
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == "RobloxPlayerBeta" || process.ProcessName == "eurotrucks2")
                {
                    RobloxRunning = true; 
                    break;
                }
            }

            // IsInjected Check //
            switch (Data.API)
            {
                case "Synapse Z":
                    IsInjected = Data.SynapseZ ? (synapseZ.IsInjected() == true) : false;
                    break;

                case "Seliware":
                    IsInjected = Data.Seliware ? Seliware.IsInjected() : false;
                    break;

                default: 
                    IsInjected = false;
                    break;
            }

            return new WrapperData
            {
                API = Data.API,
                IsInjected = IsInjected,
                RobloxRunning = RobloxRunning
            };
        }

        public static void Inject()
        {
            if (Injecting) return;

            WrapperData data = GetData();
            if (data.IsInjected) {
                MessageBox.Show("Already injected.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!data.RobloxRunning)
            {
                MessageBox.Show("Start Roblox before injecting!", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Inject //
            Injecting = true;
            switch (Data.API)
            {
                case "Synapse Z":
                    int status = synapseZ.Inject();
                    if (status != 0) MessageBox.Show(synapseZ.GetLatestErrorMessage(), "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Seliware":
                    string message = Seliware.Inject();
                    if (message.ToLower() != "success") MessageBox.Show(message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default: break;
            }
            Injecting = false;
        }

        public static (bool success, string message) Execute(string script, bool injectIfNot = false)
        {
            WrapperData data = GetData();
            if (!data.RobloxRunning)
            {
                return (false, "Roblox is not running.");
            }

            if (!data.IsInjected && injectIfNot == true) {
                Inject();

                data = GetData();
                if (!data.IsInjected) return (false, "Failed to inject.");
            }

            // Execute //
            switch (Data.API)
            {
                case "Synapse Z":
                    int status = synapseZ.Execute(script);
                    return (status == 0, status == 0 ? "" : synapseZ.GetLatestErrorMessage());

                case "Seliware":
                    bool success = Seliware.Execute(script);
                    return (success, success ? "" : "Failed to execute.");

                default:
                    return (false, "Invalid API.");
            }
        }

    }
}
