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
    public partial class Ugc : Form
    {
        private list<ClientClass> clients;

        public Ugc()
        {
            InitializeComponent();
        }

        private void ProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Produits");
            Produits frmProduits = new Produits
            {
                MdiParent = this
            };
            frmProduits.Show();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clients");
            

             Clients frmClients = new Clients
            {
                MdiParent = this
            };
            frmClients.Show();
        }

        private void FournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Fournisseurs");
        }

        private void EstimationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Estimation");
            Estimation frmEstimation = new Estimation
            {
                MdiParent = this
            };
            frmEstimation.Show();


        }

        private void DossiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Dossiers");
        }

        private void OuvrirDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ouvrir Dossier");
        }

        private void FermerDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Fermer Dossier");
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Quitter");
        }

        private void AchatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Achats");
        }

        private void EtatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Etats");
        }

        private void UtilitairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Utilitaires");
        }

        private void AideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Aide");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Tests");

            Test frmTest = new Test
            {
                MdiParent = this
            };
            frmTest.Show();
        }
    }

}
