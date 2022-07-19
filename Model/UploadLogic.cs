using System;
using System.Text;

namespace EnterTarget
{
    class UploadLogic
    {
        public static string Insert(string date, string model, int op, int scrap)
        {
            StringBuilder sqlInsertData = new StringBuilder();
            sqlInsertData.Append("Insert into thu_MQC_DailyTarget ");
            sqlInsertData.Append(@"( date, model, OUTPUT, SCRAP )");
            sqlInsertData.Append(" values ( ");
            sqlInsertData.Append("'" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "','" + model + "','" + op + "','" + scrap + "')");
            return sqlInsertData.ToString();
        }
        public static string Update(string date, string model, int op, int scrap)
        {
            StringBuilder sqlUpdateData = new StringBuilder();
            sqlUpdateData.Append("update thu_MQC_DailyTarget set OUTPUT = '" + op + "', SCRAP = '" + scrap + "' ");
            sqlUpdateData.Append("where model = '" + model + "' and Date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "'");
            return sqlUpdateData.ToString();
        }
        public static string Delete(string date, string model)
        {
            StringBuilder sqlUpdateData = new StringBuilder();
            sqlUpdateData.Append("delete from thu_MQC_DailyTarget ");
            sqlUpdateData.Append("where model = '" + model + "' and Date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "'");
            return sqlUpdateData.ToString();
        }
    }
}
