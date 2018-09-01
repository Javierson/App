using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_2
{
    public partial class Frame : Form
    {

        Controller C = new Controller();

        public Frame()
        {
            InitializeComponent();
        }

        private void BTNQueryCitas_Click(object sender, EventArgs e)
        {

            DG.DataSource = C.QueryCitaSubrogada();
        }
    }
}
