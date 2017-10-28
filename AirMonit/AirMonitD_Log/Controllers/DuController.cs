using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirMonitD_Log.Controllers
{
    public class DuController : ApiController
    {

        //database connection
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Soraia\source\repos\AirMonit\AirMonit\AirMonitD_Log\App_Data\SqlDatabase.mdf;Integrated Security=True";

       //metodos para controlador gerir a bd
       //TODO
       // mudar os return values depois de completar os metodos
       public void GetAllElements()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM ElementsTable ORDER BY Id", connection);

            SqlDataReader reader = command.ExecuteReader();
        }

        public void GetAllAlarms()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM ElementsTable ORDER BY Id", connection);

            SqlDataReader reader = command.ExecuteReader();
        }

        public void GetDataEntry()
        {

        }

        public void PutDataEntriesOnDB()
        {

        }
    }
}
