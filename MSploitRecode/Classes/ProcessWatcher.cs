using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace MSploitRecode.Classes
{
    internal class ProcessWatcher
    {
        private ManagementEventWatcher startWatch;
        private ManagementEventWatcher stopWatch;

        // Settings //
        public static List<string> CurrentProcessNames;
        public static Action<string, uint> CallbackStarted;
        public static Action<string, uint> CallbackStopped;

        public ProcessWatcher(List<string> ProcessNames, Action<string, uint> CallbackStarted_, Action<string, uint> CallbackStopped_)
        {
            CurrentProcessNames = ProcessNames;
            CallbackStarted = CallbackStarted_;
            CallbackStopped = CallbackStopped_;

            startWatch = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
            stopWatch = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");

            startWatch.EventArrived += new EventArrivedEventHandler(processStarted);
            stopWatch.EventArrived += new EventArrivedEventHandler(processStopped);

            startWatch.Start();
            stopWatch.Start();
        }

        public void Stop()
        {
            if (startWatch != null)
            {
                startWatch.Stop();
                startWatch.Dispose();
                startWatch = null;
            }

            if (stopWatch != null)
            {
                stopWatch.Stop();
                stopWatch.Dispose();
                startWatch = null;
            }
        }

        // Handlers //
        private static void processStarted(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            uint processID = (uint)e.NewEvent.Properties["ProcessID"].Value;

            if (CurrentProcessNames.Contains(processName))
                CallbackStarted(processName, processID);
        }

        private static void processStopped(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            uint processID = (uint)e.NewEvent.Properties["ProcessID"].Value;

            if (CurrentProcessNames.Contains(processName))
                CallbackStopped(processName, processID);
        }
    }
}
