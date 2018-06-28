using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UgcClassLibrary;

namespace Ugc
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            // start 
            openDbAnsBind();

        }
        private void openDbAnsBind()
        {
            var dbCon = DBConnetion.Instance();
            dbCon.DatabaseName = "ugc";
            if (dbCon.IsConnect())
            {
                MySqlDataAdapter Da = new MySqlDataAdapter();
                string query = "Call clients_all()";
                Da.SelectCommand = new MySqlCommand(query, dbCon.Connection);
                DataTable table = new DataTable();
                Da.Fill(table);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;


                dgClients.DataSource = bsource;
                // dgClients.DataBindingComplete();

            }
        }

        private void BtnAfficheColumnsWidth_Click(object sender, EventArgs e)
        {
           
           foreach (DataGridViewColumn col in dgClients.Columns) 
            {
                Console.WriteLine(col.Name+"\t"+col.Width + "\r\n");
            }
        }
    }
}
