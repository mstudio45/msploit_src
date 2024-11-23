using MSploitRecode.APIs;
using MSploitRecode.Forms;
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
        public InjectorMain() { }

        public SynapseZ synapseZ = new SynapseZ(Path.Combine(Data.ExecutorsFolder, "SynapseZ"));
        public ProcessWatcher processWatcher;

        // Variables //
        public bool Injecting { get; set; }

        private bool Setupped;

        public void Setup()
        {
            if (Setupped == true) return;
            Setupped = true;

            processWatcher = new ProcessWatcher(new List<string> { "RobloxPlayerBeta.exe", "eurotrucks2.exe" }, 
                async (string processName, uint PID) =>
                {
                    if (Data.SettingsLoaded == true && Data.Settings.AutoAttach == true && GetData().IsInjected == false) {
                        // TO-DO: Wait for seliware to have pid in isinjected and check isinjected properly
                        await Task.Delay(2500);
                        try
                        {
                            Process test = Process.GetProcessById((int)PID);
                            Inject();
                        }
                        catch
                        {
                            MessageBox.Show($"Failed to auto-attach into {processName} {PID}.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                },
                (string processName, uint PID) => {
                    
                }
            );
        }

        // Functions //
        public WrapperData GetData()
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
                    IsInjected = Data.SynapseZ ? (synapseZ.IsInjected() == true) : false; // Data.SelectedPID == -1 ? 
                    break;

                case "Seliware":
                    IsInjected = Data.Seliware ? Seliware.IsInjected() : false; // Data.SelectedPID == -1 ? 
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

        public void Inject()
        {
            if (Injecting) return;

            WrapperData data = GetData();
            if (data.IsInjected) {
                MessageBox.Show("Already injected.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!data.RobloxRunning)
            {
                MessageBox.Show("Start Roblox before injecting!", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /* Can't be added synce synapseZ.Inject doesnt have an PID arg. GET OUT
            if (Data.API != "Synapse Z" && Data.SettingsLoaded == true && Data.Settings.MultiInstance == true)
            {
                Data.SelectedPID = -1;
                new RobloxInstances().Show();
                while (Data.SelectedPID == -1)
                    await Task.Delay(150);
            }*/

            // Inject //
            Injecting = true;
            switch (Data.API)
            {
                case "Synapse Z":
                    int status = synapseZ.Inject();
                    if (status != 0) MessageBox.Show(synapseZ.GetLatestErrorMessage(), "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Seliware":
                    string message = Seliware.Inject(); // Data.SelectedPID == -1 ? Seliware.Inject() : Seliware.Inject(Data.SelectedPID);
                    if (message.ToLower() != "success") MessageBox.Show(message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default: break;
            }

            Data.SelectedPID = -1;
            Injecting = false;
        }

        public (bool success, string message) Execute(string script, bool injectIfNot = false)
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

            /* Can't be added synce Seliware.Execute doesnt have an PID arg. GET OUT
             if (Data.SettingsLoaded == true && Data.Settings.MultiInstance == true)
            {
                Data.SelectedPID = -1;
                new RobloxInstances(synapseZ.GetInjectedRobloxProcesses()).Show();
                while (Data.SelectedPID == -1)
                    await Task.Delay(150);
            }*/

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
