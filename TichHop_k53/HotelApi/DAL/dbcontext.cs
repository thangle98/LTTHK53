using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace HotelApi.DAL
{
    public class dbcontext
    {
        public SqlConnection dataConection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-50A3VEU\SQLEXPRESS;Initial Catalog=QLKS;Persist Security Info=False;User ID=sa;Password=123456;Encrypt=False;TrustServerCertificate=False");
        }

        public void ExecuteNonQuery(string querySQL)
        {
            SqlConnection connection = dataConection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querySQL, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch
            {


            }
            finally
            {
                connection.Close();
            }
        }

        public List<T> Query<T>(string query) where T : new()
        {
            SqlConnection connection = dataConection();
            try
            {
                connection.Open();
                List<T> res = new List<T>();
                SqlCommand q = new SqlCommand(query, connection);
                SqlDataReader r = q.ExecuteReader();
                while (r.Read())
                {
                    T t = new T();

                    for (int inc = 0; inc < r.FieldCount; inc++)

                    {
                        Type type = t.GetType();
                        PropertyInfo prop = type.GetProperty(r.GetName(inc));
                        if (r.GetValue(inc) == DBNull.Value)
                        {
                            prop.SetValue(t, null);
                        }
                        else
                        {
                            prop.SetValue(t, r.GetValue(inc));
                        }

                    }
                    res.Add(t);
                }
                r.Close();
                return res;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            } 
        }
    }
}