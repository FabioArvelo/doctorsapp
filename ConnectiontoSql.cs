using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModernGUI_V3
{
    public abstract class ConnectiontoSql
    {
        private readonly string connectionString;
        public ConnectiontoSql() {
            connectionString = "Server=LAPTOP-V9HJ4OMN;DataBase= DMA; integrated security= true";
        }
        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString); 
            
        }
    }
}
