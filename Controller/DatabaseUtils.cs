
using System.Data.SqlClient;

namespace EnterTarget
{
    class DatabaseUtils
    {
        public static SqlConnection GetSoftDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "ERPSOFT";
            string username = "ERPUSER";
            string password = "12345";
            return DatabaseSQLServerUtils.GetSoftDBConnection(datasource, database, username, password);
        }
    }
}
