using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp
{
    using System;
    using System.Data;
    using Oracle.ManagedDataAccess.Client;

    public class DatabaseHelper
    {
        private string connectionString = "User Id=system;Password=sys123;Data Source=localhost:1521/XEPDB1";

        public OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection(connectionString);
            return conn;
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query)
        {
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    return cmd.ExecuteScalar();
                }
            }
        }

    }

}
