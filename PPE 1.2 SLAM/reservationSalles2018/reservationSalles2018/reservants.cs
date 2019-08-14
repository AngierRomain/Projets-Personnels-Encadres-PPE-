using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservationSalles2018
{
    public partial class reservants : Form
    {
        //Initialisation du Tableau
        DataTable tableReservants = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservants"];
        Boolean enregModifierReservant;
        public reservants()
        {
            InitializeComponent();
        }
        //Chargement de l'interface des reservants
        private void reservants_Load(object sender, EventArgs e)
        {
            lbxReservants.DataSource = tableReservants;
            lbxReservants.DisplayMember = tableReservants.Columns[1].ToString();
            lbxReservants.ValueMember = tableReservants.Columns[0].ToString();

            tbxNomReservant.Enabled = false;
            tbxTelephoneReservant.Enabled = false;
            tbxMailReservant.Enabled = false;

            btnEnregistrerReservant.Visible = false;
            btnAnnulerReservant.Visible = false;

            btnRechercherReservant.Enabled = true;
        }

        private void lbxReservants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxReservants.SelectedIndex != -1)
            {
                tbxNomReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[1].ToString();
                tbxTelephoneReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[2].ToString();
                tbxMailReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[3].ToString();

            }
        }

        private void btnRechercherReservant_Click(object sender, EventArgs e)
        {
            //Initialisation des variables
            int index = lbxReservants.FindString(tbxRechercherReservant.Text);

            //Si on ne trouve pas le reservant alors retourner "Réservant introuvable"
            if (index == -1)
            {
                MessageBox.Show("Réservant introuvable.");
            }
            else
            {
                lbxReservants.SetSelected(index, true);
            }
        }

        private void btnModifierReservant_Click(object sender, EventArgs e)
        {
            if (tbxNomReservant.Text != "")
            {
                //Modification des réservants 
                enregModifierReservant = true;
                tbxNomReservant.Enabled = true;
                tbxTelephoneReservant.Enabled = true;
                tbxMailReservant.Enabled = true;

                btnAjouterReservant.Visible = false;
                btnSupprimerReservant.Visible = false;
                btnModifierReservant.Enabled = false;

                btnEnregistrerReservant.Visible = true;
                btnAnnulerReservant.Visible = true;

                lbxReservants.Enabled = false;
                tbxRechercherReservant.Enabled = false;
                btnRechercherReservant.Enabled = false;
            }
        }

        private void btnAnnulerReservant_Click(object sender, EventArgs e)
        {
            //Annulation de la réservation
            enregModifierReservant = false;

            tbxNomReservant.Enabled = false;
            tbxTelephoneReservant.Enabled = false;
            tbxMailReservant.Enabled = false;

            btnAjouterReservant.Visible = true;
            btnSupprimerReservant.Visible = true;
            btnModifierReservant.Enabled = true;

            btnEnregistrerReservant.Visible = false;
            btnAnnulerReservant.Visible = false;

            lbxReservants.Enabled = true;
            tbxRechercherReservant.Enabled = true;
            btnRechercherReservant.Enabled = true;

            if (lbxReservants.SelectedIndex != -1)
            {
                tbxNomReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[1].ToString();
                tbxTelephoneReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[2].ToString();
                tbxMailReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[3].ToString();

            }
        }

        private void btnAjouterReservant_Click(object sender, EventArgs e)
        {
            //On ajoute la réservation
            tbxNomReservant.Text = "";
            tbxTelephoneReservant.Text = "";
            tbxMailReservant.Text = "";

            tbxNomReservant.Enabled = true;
            tbxTelephoneReservant.Enabled = true;
            tbxMailReservant.Enabled = true;

            btnAjouterReservant.Visible = false;
            btnSupprimerReservant.Visible = false;
            btnModifierReservant.Enabled = false;

            btnEnregistrerReservant.Visible = true;
            btnAnnulerReservant.Visible = true;

            lbxReservants.Enabled = false;
            tbxRechercherReservant.Enabled = false;
            btnRechercherReservant.Enabled = false;
        }

        private void btnEnregistrerReservant_Click(object sender, EventArgs e)
        {
            //Initialisation des variables
            int idReservant;
            short indice;

            indice = 0;

            //Vérifier saisie

            tbxNomReservant.Text = tbxNomReservant.Text.Trim();
            tbxTelephoneReservant.Text = tbxTelephoneReservant.Text.Trim();
            tbxMailReservant.Text = tbxMailReservant.Text.Trim();
            //Verification de la saisie
            if (tbxNomReservant.Text == "")
            {

                //Si la saisie n'est pas un nom de réservant
                MessageBox.Show("Vous devez saisir un nom de réservant", "Erreur de saisie");
                tbxNomReservant.Text = "";
                tbxNomReservant.Focus();
            }
            else if (tbxTelephoneReservant.Text.Trim() == "")
            {
                //Si l'utilisateur n'a pas saisi un numéro de téléphone
                MessageBox.Show("Vous devez saisir un numéro de téléphone", "Erreur de saisie");
                tbxTelephoneReservant.Text = "";
                tbxTelephoneReservant.Focus();
            }
            else if (tbxMailReservant.Text.Trim() == "")
            {
                //Si la valeur saisie n'est pas une adresse mail
                MessageBox.Show("Vous devez saisir une adresse mail", "Erreur de saisie");
                tbxMailReservant.Text = "";
                tbxMailReservant.Focus();
            }
            else
            {
                if (enregModifierReservant == false)
                {
                    dbConnexion.ajouterReservant(tbxNomReservant.Text, tbxTelephoneReservant.Text, tbxMailReservant.Text);
                }
                else
                {
                    idReservant = Convert.ToInt32(tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[0]);
                    dbConnexion.modifierReservant(idReservant, tbxNomReservant.Text, tbxTelephoneReservant.Text, tbxMailReservant.Text);
                    indice = Convert.ToInt16(lbxReservants.SelectedIndex);

                }

                try
                {
                    dbConnexion.miseJourDataSet();
                    lbxReservants.DataSource = tableReservants;
                    lbxReservants.DisplayMember = tableReservants.Columns[1].ToString();


                    if (enregModifierReservant == true)
                    {
                        lbxReservants.SelectedIndex = indice;
                        enregModifierReservant = false;
                    }
                    else
                    {
                        lbxReservants.SelectedIndex = lbxReservants.Items.Count - 1;
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }

                tbxNomReservant.Enabled = false;
                tbxTelephoneReservant.Enabled = false;
                tbxMailReservant.Enabled = false;

                btnAjouterReservant.Visible = true;
                btnSupprimerReservant.Visible = true;
                btnModifierReservant.Enabled = true;

                btnEnregistrerReservant.Visible = false;
                btnAnnulerReservant.Visible = false;

                lbxReservants.Enabled = true;
                tbxRechercherReservant.Enabled = true;
                btnRechercherReservant.Enabled = true;

                if (lbxReservants.SelectedIndex != -1)
                {
                    tbxNomReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[1].ToString();
                    tbxTelephoneReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[2].ToString();
                    tbxMailReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[3].ToString();

                }
            }
        }

        private void btnSupprimerReservant_Click(object sender, EventArgs e)
        {
            
            int idReservant;

            if (lbxReservants.SelectedIndex >= 0)
            {
                // On demande si on veut supprimer l'enregistrement
                DialogResult dialogResult = MessageBox.Show("Voulez vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        idReservant = Convert.ToInt32(tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[0]);
                        dbConnexion.supprimerReservant(idReservant);
                        dbConnexion.miseJourDataSet();
                        tbxNomReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[1].ToString();
                        tbxTelephoneReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[2].ToString();
                        tbxMailReservant.Text = tableReservants.Rows[lbxReservants.SelectedIndex].ItemArray[3].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Suppression impossible");
                    }

                }
            }
            else
            {
                //Erreur
                MessageBox.Show("Vous devez sélectionner un réservant");
            }


    
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
