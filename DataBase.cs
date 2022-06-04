using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace optbaze
{
    class DataBase
    {
        SqlConnection splConnection = new SqlConnection(@"Data Source=DESKTOP-EBCOA4S\SQLEXPRESS; Initial Catalog=optbaze; Integrated Security=True; TrustServerCertificate=True");
        SqlDataAdapter da; 
        DataSet ds;
        SqlCommand sqlCommand; 

        public void openConnection()
        {
            if (splConnection.State == System.Data.ConnectionState.Closed)
            {
                splConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (splConnection.State == System.Data.ConnectionState.Open)
            {
                splConnection.Close();
            }
        }

        public DataTable dataShow(string nameTable)
        {
            openConnection();
            da = new SqlDataAdapter("Select * From " + nameTable, splConnection);
            ds = new DataSet();
            da.Fill(ds, nameTable);
            closeConnection();
            return ds.Tables[nameTable];
        }

        public DataTable sqlShow(string request)
        {
            openConnection();
            da = new SqlDataAdapter(request, splConnection);
            ds = new DataSet();
            da.Fill(ds);
            closeConnection();
            return ds.Tables[0];
        }

        public void sqlUpdate(string request)
        {
            openConnection();
            sqlCommand = new SqlCommand(request, splConnection);
            sqlCommand.ExecuteNonQuery();
            closeConnection();
        }

        public string sqlToString(string request)
        {
            openConnection();
            sqlCommand = new SqlCommand(request, splConnection);
            if (sqlCommand.ExecuteScalar() != null)
            {
                return sqlCommand.ExecuteScalar().ToString();
            }  
            else
            {
                return null;
            } 
        }
    }
}
