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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text == "") return;
            var dbCon = DBConnetion.Instance();
            dbCon.DatabaseName = "ugc";
            if (dbCon.IsConnect())
            {
                string query = txtQuery.Text; //" call clients_all()";//"SELECT * FROM tiers";
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                

                while (reader.Read())
                {

                    int id = reader.GetInt16("id");
                    string code = (reader.IsDBNull(1)) ? "" : reader.GetString("code");
                    string famille = (reader.IsDBNull(2)) ? "" : reader.GetString("famille");
                    string raison = (reader.IsDBNull(3)) ? "" : reader.GetString("raison");
                    //raison = reader.GetString("raison");
                    decimal solde = reader.GetDecimal("solde");
                    string fixe = (reader.IsDBNull(5)) ? "" : reader.GetString("fixe");
                    string mobile = (reader.IsDBNull(6)) ? "" : reader.GetString("mobile");
                    string email = (reader.IsDBNull(7)) ? "" : reader.GetString("email");
                    string fax = (reader.IsDBNull(8)) ? "" : reader.GetString("fax");
                    decimal chiffre_affaire = reader.GetDecimal("chiffre_affaire");
                    string ville = (reader.IsDBNull(10)) ? "" : reader.GetString("ville");
                    string modereglement = (reader.IsDBNull(11)) ? "" : reader.GetString("modereglement");
                    string type = (reader.IsDBNull(12)) ? "" : reader.GetString("type");
                    string adresse = (reader.IsDBNull(13)) ? "" : reader.GetString("adresse");

                    txtResult.Text += id + "\t" + code + "\t" + raison + "\t"
                                      + fixe + "\t" + mobile + "\t" + fax + "\t" + email +"\t"
                                      + famille + "\t" + solde + "\t" + chiffre_affaire + "\t"
                                      + ville + "\t" + modereglement + "\t" + type + "\t" + adresse+"\r\n";
                    /*
                    Console.WriteLine(id + "\t" + code + "\t" + raison + "\t"
                                      + fixe + "\t" + mobile + "\t" + fax + "\t" + email + "\t"
                                      + famille + "\t" + solde + "\t" + chiffre_affaire + "\t"
                                      + ville + "\t" + modereglement + "\t" + type + "\t" + adresse
                                      );
                    */
                }
                Console.WriteLine(reader.GetSchemaTable().TableName);

                reader.Close();
                
               // dbCon.Close();
            }
        }
    }
}
