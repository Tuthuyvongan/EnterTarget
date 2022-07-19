using System;
using System.Text;

namespace SMESData
{
    class UploadLogic
    {
        public static string Insert(string model, string date, string line, string NG)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlInsertData = new StringBuilder();
            model = SaveData.Model;
            date = SaveData.Date;
            NG = SaveData.NGallow;
            line = SaveData.line;
            if (SaveData.PQC == true)
            {
                sqlInsertData.Append("Insert into thu_SMESData_NGRate_PQC ");
                sqlInsertData.Append(@"( Model, Line, Date, rate )");
                sqlInsertData.Append(" values ( ");
                sqlInsertData.Append("'" + model + "','" + line + "','" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "','" + NG + "')");
            }
            else
            {
                sqlInsertData.Append("Insert into thu_SMESData_NGRate ");
                sqlInsertData.Append(@"( model, inspectdate, line, rate )");
                sqlInsertData.Append(" values ( ");
                sqlInsertData.Append("'" + model + "','" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "','" + line + "','" + NG + "')");
            }    
            
            return sqlInsertData.ToString();
        }
        public static string Update(string model, string date, string line, string NG)
        {
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlUpdateData = new StringBuilder();
            model = SaveData.Model;
            date = SaveData.Date;
            NG = SaveData.NGallow;
            if (SaveData.PQC == true)
            {
                sqlUpdateData.Append("update thu_SMESData_NGRate_PQC set Model = '" + model + "', Date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "', rate = '" + NG + "' ");
                sqlUpdateData.Append("where Model = '" + model + "' and Date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "'");
            }
            else
            {
                sqlUpdateData.Append("update thu_SMESData_NGRate set model = '" + model + "', inspectdate = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "', rate = '" + NG + "' ");
                sqlUpdateData.Append("where model = '" + model + "' and inspectdate = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "'");
            }
            return sqlUpdateData.ToString();
        }
    }
}
