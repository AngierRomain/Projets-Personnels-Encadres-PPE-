using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace M2L_JPO
{
    public partial class MembreInscription : Form
    {
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbConnection autreConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;
        

        String codeMembre;
        byte creneau;

        public MembreInscription()
        {
            InitializeComponent();
        }

        private void MembreInscription_Load(object sender, EventArgs e)
        {
            OleDbCommand autreCommande = new OleDbCommand();
            OleDbDataReader autreDR;
            dgvMembreInscription.RowHeadersVisible = false;
            maCommande.Connection = maConnexion;
            autreCommande.Connection = autreConnexion;
            maConnexion.Open();
            autreConnexion.Open();



            dgvMembreInscription.ColumnCount = 3;
            dgvMembreInscription.Columns[0].HeaderText = "Membre";
            dgvMembreInscription.Columns[1].HeaderText = "Code Membre";
            dgvMembreInscription.Columns[2].HeaderText = "Créneau";


            //les codes et créneaux correspondants
            maCommande.CommandText = "SELECT * FROM PARTICIPER";
            unDR = maCommande.ExecuteReader();
            int i = 0;

            while (unDR.Read())
            {

                dgvMembreInscription.Rows.Add();
                 
                dgvMembreInscription[1, i].Value = unDR.GetValue(0).ToString();
                dgvMembreInscription[2, i].Value = unDR.GetValue(1).ToString();

                //On met dans la colonne 0 les noms et prénoms correspondant aux codeMembres
                autreCommande.CommandText = "SELECT nom, prénom FROM MEMBRE WHERE codeMembre =" + dgvMembreInscription[1, i].Value;
                autreDR = autreCommande.ExecuteReader();
                while (autreDR.Read())
                {
                    dgvMembreInscription[0, i].Value = autreDR.GetValue(0).ToString() + " " + autreDR.GetValue(1).ToString();
                }
                i++;   
            }
            unDR.Close();
            autreConnexion.Close();




            maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                cbxChoisirMembre.Items.Add(unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString());
            }


            unDR.Close();
            maConnexion.Close();
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            if(cbMatin.Checked)
            {
                creneau = 1;
            }
            else if (cbAprem.Checked)
            {
                creneau = 2;
            }
            else if(cbMatin.Checked && cbAprem.Checked)
            {
                creneau = 3;
            }
            else
            {
                creneau = 0;
            }

            String nomMembre = cbxChoisirMembre.SelectedItem.ToString().Split(' ')[0];

            if (cbxChoisirMembre.Text == "")
            {
                MessageBox.Show("Vous devez selectionner un créneau", "Erreur de selection");
            }
            else if (creneau == 0)
            {
                MessageBox.Show("Vous devez selectionner un créneau", "Erreur de selection");
            }
            else
            {
                try
                {


                    maCommande.Connection = maConnexion;
                    maConnexion.Open();
                    maCommande.CommandText = "SELECT codeMembre FROM MEMBRE WHERE nom = '" + nomMembre + "'";
                    unDR = maCommande.ExecuteReader();
                    while (unDR.Read())
                    {
                        codeMembre = unDR.GetValue(0).ToString();
                        maCommande.CommandText = "INSERT INTO PARTICIPER(codeMembre, codeCréneau) values ('" + codeMembre + "', '" + creneau.ToString() + "')";
                    }
                    unDR.Close();
                    maCommande.ExecuteNonQuery();


                    //Regenerer le dgv
                    maCommande.CommandText = "SELECT codeMembre, codeCréneau FROM PARTICIPER";
                    unDR = maCommande.ExecuteReader();
                    int i = 0;

                    while (unDR.Read())
                    {

                        dgvMembreInscription.Rows.Add();
                        dgvMembreInscription[0, i].Value = unDR.GetValue(0).ToString();
                        dgvMembreInscription[1, i].Value = unDR.GetValue(1).ToString();

                        i++;

                    }
                    unDR.Close();
                    maConnexion.Close();
                }
                catch
                {
                    MessageBox.Show("Ce membre est déjà inscrit!", "Erreur de selection");
                }
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (cbxChoisirMembre.Text == "")
            {
                MessageBox.Show("Vous devez selectionner un membre", "Erreur de selection");
            }
            else if (cbMatin.Checked == false && cbMatin.Checked == false)
            {
                MessageBox.Show("Vous devez selectionner un créneau", "Erreur de selection");
            }
            else
            {
                maCommande.Connection = maConnexion;
                maConnexion.Open();
                maCommande.CommandText = "UPDATE MEMBRE SET créneau = '" + creneau + "' WHERE codeMembre = '" + cbxChoisirMembre.SelectedItem.ToString() + "';";
                maCommande.ExecuteNonQuery();
                maConnexion.Close();
            }
        }

        private void btnFiltreMembre_Click(object sender, EventArgs e)
        {
            dgvMembreInscription.Rows.Clear();
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            //requête qui va chercher les noms qui commencent par les lettres mises dans le textbox
            //maCommande.CommandText = "SELECT nom FROM MEMBRE WHERE nom LIKE '" + tbxFiltreMembre.Text.ToString() + "%'";
            //maCommande.CommandText = "SELECT codeMembre, codeCréneau FROM PARTICIPER WHERE nom LIKE '%" + tbxFiltreMembre.Text.ToString() + "% OR prénom LIKE '%" + tbxFiltreMembre.Text.ToString() + "%';";
            unDR = maCommande.ExecuteReader();
            int i = 0;

            while (unDR.Read())
            {

                dgvMembreInscription.Rows.Add();
                dgvMembreInscription[0, i].Value = unDR.GetValue(0).ToString();
                dgvMembreInscription[1, i].Value = unDR.GetValue(1).ToString();

                i++;

            }
            unDR.Close();
            maConnexion.Close();
        }
    }
}
