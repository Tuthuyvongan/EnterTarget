using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace EnterTarget
{
    class GetSOFTdata
    {
        //total data in every line
        public static DataTable getAllModel(string date)
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("SELECT distinct t1.model as MODEL, '0' as OUTPUT, '0' as SCRAP FROM m_ERPMQC_REALTIME t1 ");
            sqlGetData.Append("LEFT JOIN thu_MQC_DailyTarget t2 ON t1.model = t2.model and t2.Date = '" + date + "' where t1.model != '' and t2.model IS NULL");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
        public static DataTable getTarget(string date)
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("SELECT model as MODEL, Date as DATE, OUTPUT, SCRAP FROM thu_MQC_DailyTarget where date = '" + date + "'");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
    }
}