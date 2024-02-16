using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace restaurantSystem
{
    class DB
    {
        SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True");

        //        SqlConnection connection = new SqlConnection("server=DESKTOP-SQALOGI;Initial Catalog=restaurant;Integrated Security=True");

        //create a function to open the connection

        //create a function to open the connection
        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    //    //create a function to close the connection

    //    public void closeConnection()
    //{

    //    if (connection.State == System.Data.ConnectionState.Open)
    //    {
    //        connection.Close();


    //    }
    //}


    public SqlConnection getConnection()
    {

        return connection;



    }
}
}
