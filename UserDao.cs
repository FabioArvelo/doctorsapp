using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capasinom; 

namespace ModernGUI_V3
{
    public class UserDao:ConnectiontoSql
    {
        public bool Login2(string user, string pass) { 
            using (var connection= GetConnection()) {
                connection.Open();
                using (var command= new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select * from tableusers where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.UserID = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);

                        }
                        return true;
                    }
                    else
                        return false; 
                }
            }
        }
    }
}
