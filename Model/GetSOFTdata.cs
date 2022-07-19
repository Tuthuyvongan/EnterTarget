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
        public static DataTable getAllModel()
        {
            DataTable dt = new DataTable();
            sqlSOFTCon sqlSOFTCon = new sqlSOFTCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("SELECT distinct model as Model, '0' as OUTPUT, '0' as SCRAP FROM m_ERPMQC_REALTIME where model != ''");
            sqlSOFTCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
    }
}