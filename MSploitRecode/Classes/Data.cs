using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSploitRecode.Classes
{
    internal class Data
    {
        // Domain //
        public static string DOMAIN { get; set; } = "https://msploit.mstudio45.com/";

        // Versions //
        public static string CURRENT_GUI_VERSION { get; set; } = "2.0.1";
        public static string GUI_VERSION { get; set; }
        public static bool OUTDATED { get; set; } = false;

        // Folders //
        public static string TempFolder { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "ms_tmp");
        public static string BinFolder { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "ms_bin");
        public static string IDEFolder { get; set; } = Path.Combine(BinFolder, "IDE");
        public static string ExecutorsFolder { get; set; } = BinFolder; // Path.Combine(BinFolder, "exe");

        public static string TabsFolder { get; set; } = Path.Combine(BinFolder, "tabs");

        public static string UIFile { get; set; } = Path.Combine(BinFolder, "ui.msploit");
        public static string APIFile { get; set; } = Path.Combine(BinFolder, "api.msploit");

        // Changeable strings //
        public static string Changelogs { get; set; } = "Fetching...";

        // APIs //
        public static bool SynapseZ { get; set; }
        public static bool Seliware { get; set; }
        public static bool SeliwareLoaded { get; set; }
        public static string API { get; set; } = "???";

        // Info //
        public static int TotalTabs { get; set; } = 0;
    }
}
