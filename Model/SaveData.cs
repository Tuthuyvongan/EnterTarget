using System.Data;

namespace SMESData
{
    public class SaveData
    {       
        public static double total { get; set; }
        public static double target { get; set; }
        public static double op { get; set; }
        public static double rw { get; set; }       
        public static double ng { get; set; }     
        public static string line { get; set; }
        public static double NGrealtime { get; set; }
        public static string NGallow { get; set; }
        public static double RWrealtime { get; set; }
        public static string RWallow { get; set; }
        public static string Model { get; set; }
        public static bool MQCClick { get; set; }
        public static bool PQCClick { get; set; }
        public static bool MQC { get; set; }
        public static bool PQC { get; set; }
        public static string Date { get; set; }
        public static DataTable dtTemp1 { get; set; }
        public static DataTable dtTemp2 { get; set; }
        public static int uc_mqc { get; set; }
        public static int uc_pqc { get; set; }
        public static int uc_pi { get; set; }
        public static bool check { get; set; }
    }
}
