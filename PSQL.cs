using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using NpgsqlTypes;

namespace App_2
{
    class PSQL {

        private NpgsqlConnection Connection = new NpgsqlConnection();

        public String CadenaDeConecion() {
            /*
            String userID = "postgres";
            String password = "postgres";
            String host = "localhost";
            String port = "5432";
            String database = "Prueba";
            */
            return "Username = postgres; Password = postgres; Host = localhost; Port = 5432; Database = Prueba";
            //return "User ID = " + userID + "; Password = " + password + "; Host = " + host + "; Port = " + port + "; Database = " + database;
        }
    }
}
