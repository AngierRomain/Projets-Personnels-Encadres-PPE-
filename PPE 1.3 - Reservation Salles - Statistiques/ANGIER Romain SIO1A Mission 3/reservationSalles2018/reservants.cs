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
        DataTable tableReservants = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservants"];
        Boolean enregModifierReservant;
        public reservants()
        {
            InitializeComponent();
        }

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
            int index = lbxReservants.FindString(tbxRechercherReservant.Text);
            if (index == -1)
            {
                MessageBox.Show("Reéservant introuvable.");
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
            
            int idReservant;
            short indice;

            indice = 0;

            //Vérifier saisie

            tbxNomReservant.Text = tbxNomReservant.Text.Trim();
            tbxTelephoneReservant.Text = tbxTelephoneReservant.Text.Trim();
            tbxMailReservant.Text = tbxMailReservant.Text.Trim();

            if (tbxNomReservant.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom de réservant", "Erreur de saisie");
                tbxNomReservant.Text = "";
                tbxNomReservant.Focus();
            }
            else if (tbxTelephoneReservant.Text.Trim() == "")
            {
                MessageBox.Show("Vous devez saisir un numéro de téléphone", "Erreur de saisie");
                tbxTelephoneReservant.Text = "";
                tbxTelephoneReservant.Focus();
            }
            else if (tbxMailReservant.Text.Trim() == "")
            {
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
                MessageBox.Show("Vous devez sélectionner un réservant");
            }


    
        
        }
    }
}
