using System.Data;

namespace EnterTarget
{
    public class SaveData
    {       
        public static string Date { get; set; }
        public static DataTable dtTemp1 { get; set; }
        public static DataTable dtTemp2 { get; set; }
        public static string AllModel { get; set; }  
        public static int op { get; set; }
        public static int scrap { get; set; }
        public static string Model { get; set; }
        public static int opTarget { get; set; }
        public static int scrapTarget { get; set; }
    }
}
