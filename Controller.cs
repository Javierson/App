using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using NpgsqlTypes;

namespace App_2
{
    class Controller {

        PSQL PSQL = new PSQL();
        private NpgsqlConnection Connection = new NpgsqlConnection();

        public DataTable QueryCitaSubrogada() {

            DataTable DT = new DataTable();
            Connection.ConnectionString = PSQL.CadenaDeConecion();

            try {
                Connection.Open();
                NpgsqlDataAdapter DA = new NpgsqlDataAdapter ("SELECT * FROM Cat_Citas_Subrogadas", Connection);
                DA.Fill(DT);
                Connection.Close();
                return DT;
            }
            catch (Exception E) {
                MessageBox.Show(E.Message);
                return null;
            }
        }

    }
}
