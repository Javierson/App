using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using NpgsqlTypes;

namespace App_2
{
    public partial class Frame : Form
    {
        PSQL PSQL = new PSQL();
        Controller C = new Controller();
        NpgsqlConnection Connection = new NpgsqlConnection();

        public Frame()
        {
            InitializeComponent();
        }

        private void BTNQueryCitas_Click(object sender, EventArgs e)
        {
            LVCitasSubrogados.Items.Clear();
            //LVCitasSubrogados.Items.AddRange(C.QueryCitaSubrogada()); //C.QueryCitaSubrogada();
            // Metodo consulta
            /*
            Connection.ConnectionString = PSQL.CadenaDeConecion();

            try {
                Connection.Open();
                NpgsqlDataAdapter DA = new NpgsqlDataAdapter("SELECT * FROM cat_citas_subrogadas", Connection);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                foreach (DataRow R in DT.Rows) {
                    ListViewItem I = new ListViewItem(R["ID Cita Subrogada"].ToString());
                    I.SubItems.Add(R["Paciente"].ToString());
                    I.SubItems.Add(R["Estudio"].ToString());
                    I.SubItems.Add(R["Clase"].ToString());
                    I.SubItems.Add(R["Region"].ToString());
                    I.SubItems.Add(R["Medico"].ToString());
                    I.SubItems.Add(R["Empresa"].ToString());
                    I.SubItems.Add(R["Procedencia"].ToString());
                    I.SubItems.Add(R["Coordinacion"].ToString());
                    LVCitasSubrogados.Items.Add(I);
                }
                Connection.Close();
                DT.Rows.Clear();
            }
            catch (Exception E) {
                MessageBox.Show(E.Message, "Componente ListView");
            }
            */
        }
    }
}
