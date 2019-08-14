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
    public partial class salles : Form
    {
        DataTable tableSalles;
        Boolean enregModifierSalle;

        public salles()
        {
            InitializeComponent();
        }

        private void salles_Load(object sender, EventArgs e)
        {

            tableSalles = M2LReservationSalles.reservationsSallesDataSet.Tables["Salles"];
            lbxSalles.DataSource = tableSalles;
            lbxSalles.DisplayMember = tableSalles.Columns[1].ToString();
            lbxSalles.ValueMember = tableSalles.Columns[0].ToString();

            tbxNomSalle.Enabled = false;
            tbxTypeSalle.Enabled = false;
            tbxSurfaceSalle.Enabled = false;
            tbxCapaciteSalle.Enabled = false;

            btnEnregistrerSalle.Visible = false;
            btnAnnulerSalle.Visible = false;
        }

        private void lbxSalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSalles.SelectedIndex != -1)
            {
                tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                tbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[2].ToString();
                tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
            }
        }

        private void btnRechercheSalle_Click(object sender, EventArgs e)
        {
            int index = lbxSalles.FindString(tbxRechercherSalle.Text);
            if (index == -1)
            {
                MessageBox.Show("Salle introuvable.");
            }
            else
            {
                lbxSalles.SetSelected(index, true);
            }
        }

        private void btnModifierSalle_Click(object sender, EventArgs e)
        {
            if (tbxNomSalle.Text != "")
            {
                enregModifierSalle = true;
                tbxNomSalle.Enabled = true;
                tbxTypeSalle.Enabled = true;
                tbxSurfaceSalle.Enabled = true;
                tbxCapaciteSalle.Enabled = true;

                btnAjouterSalle.Visible = false;
                btnSupprimerSalle.Visible = false;
                btnModifierSalle.Enabled = false;

                btnEnregistrerSalle.Visible = true;
                btnAnnulerSalle.Visible = true;

                lbxSalles.Enabled = false;
                tbxRechercherSalle.Enabled = false;
            }
        }

        private void btnAnnulerSalle_Click(object sender, EventArgs e)
        {
            enregModifierSalle = false;

            tbxNomSalle.Enabled = false;
            tbxTypeSalle.Enabled = false;
            tbxSurfaceSalle.Enabled = false;
            tbxCapaciteSalle.Enabled = false;

            btnAjouterSalle.Visible = true;
            btnSupprimerSalle.Visible = true;
            btnModifierSalle.Enabled = true;

            btnEnregistrerSalle.Visible = false;
            btnAnnulerSalle.Visible = false;

            lbxSalles.Enabled = true;
            tbxRechercherSalle.Enabled = true;

            if (lbxSalles.SelectedIndex != -1)
            {
                tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                tbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[2].ToString();
                tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
            }
        }

        private void btnAjouterSalle_Click(object sender, EventArgs e)
        {
            tbxNomSalle.Text = "";
            tbxTypeSalle.Text = "";
            tbxSurfaceSalle.Text = "";
            tbxCapaciteSalle.Text = "";

            tbxNomSalle.Enabled = true;
            tbxTypeSalle.Enabled = true;
            tbxSurfaceSalle.Enabled = true;
            tbxCapaciteSalle.Enabled = true;

            btnAjouterSalle.Visible = false;
            btnSupprimerSalle.Visible = false;
            btnModifierSalle.Enabled = false;

            btnEnregistrerSalle.Visible = true;
            btnAnnulerSalle.Visible = true;

            lbxSalles.Enabled = false;
            tbxRechercherSalle.Enabled = false;
        }

        private void btnEnregistrerSalle_Click(object sender, EventArgs e)
        {
            int idSalle;
            short surface, capacite, indice;

            indice = 0;

            //Vérifier saisie

            tbxNomSalle.Text = tbxNomSalle.Text.Trim();
            tbxTypeSalle.Text = tbxTypeSalle.Text.Trim();

            if (tbxNomSalle.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom de salle", "Erreur de saisie");
                tbxNomSalle.Text = "";
                tbxNomSalle.Focus();
            }
            else if (tbxTypeSalle.Text.Trim() == "")
            {
                MessageBox.Show("Vous devez saisir un type de salle", "Erreur de saisie");
                tbxTypeSalle.Text = "";
                tbxTypeSalle.Focus();
            }
            else if (tbxTypeSalle.Text != "" && tbxNomSalle.Text != "")
            {
                try
                {
                    surface = Convert.ToInt16(tbxSurfaceSalle.Text);
                }
                catch
                {
                    MessageBox.Show("Vous devez saisir une surface valide", "Erreur de saisie");
                    tbxSurfaceSalle.Text = "";
                    tbxSurfaceSalle.Focus();
                }
                if (tbxSurfaceSalle.Text != "")
                {
                    try
                    {
                        capacite = Convert.ToInt16(tbxCapaciteSalle.Text);

                        if (enregModifierSalle == false)
                        {
                            dbConnexion.ajouterSalle(tbxNomSalle.Text, tbxTypeSalle.Text, Convert.ToInt16(tbxSurfaceSalle.Text), Convert.ToInt16(tbxCapaciteSalle.Text));
                        }
                        else
                        {
                            idSalle = Convert.ToInt32(tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[0]);
                            dbConnexion.modifierSalle(idSalle, tbxNomSalle.Text, tbxTypeSalle.Text, Convert.ToInt16(tbxSurfaceSalle.Text), Convert.ToInt16(tbxCapaciteSalle.Text));
                            indice = Convert.ToInt16(lbxSalles.SelectedIndex);

                        }

                        try
                        {
                            dbConnexion.miseJourDataSet();
                            lbxSalles.DataSource = tableSalles;
                            lbxSalles.DisplayMember = tableSalles.Columns[1].ToString();


                            if (enregModifierSalle == true)
                            {
                                lbxSalles.SelectedIndex = indice;
                                enregModifierSalle = false;
                            }
                            else
                            {
                                lbxSalles.SelectedIndex = lbxSalles.Items.Count - 1;
                            }
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.Message);
                        }


                        tbxNomSalle.Enabled = false;
                        tbxTypeSalle.Enabled = false;
                        tbxSurfaceSalle.Enabled = false;
                        tbxCapaciteSalle.Enabled = false;

                        btnAjouterSalle.Visible = true;
                        btnSupprimerSalle.Visible = true;
                        btnModifierSalle.Enabled = true;

                        btnEnregistrerSalle.Visible = false;
                        btnAnnulerSalle.Visible = false;

                        lbxSalles.Enabled = true;
                        tbxRechercherSalle.Enabled = true;
                        if (lbxSalles.SelectedIndex != -1)
                        {
                            tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                            tbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[2].ToString();
                            tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                            tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Vous devez saisir une capacité valide", "Erreur de saisie");
                        tbxCapaciteSalle.Text = "";
                        tbxCapaciteSalle.Focus();

                    }
                }
            }
        }

        private void btnSupprimerSalle_Click(object sender, EventArgs e)
        {
            int idSalle;
            try
            {
                if (lbxSalles.SelectedIndex >= 0)
                {
                    idSalle = Convert.ToInt32(tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[0]);
                    dbConnexion.supprimerSalle(idSalle);
                    dbConnexion.miseJourDataSet();

                    if (lbxSalles.SelectedIndex != -1)
                    {
                        tbxNomSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[1].ToString();
                        tbxTypeSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[2].ToString();
                        tbxSurfaceSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[3].ToString();
                        tbxCapaciteSalle.Text = tableSalles.Rows[lbxSalles.SelectedIndex].ItemArray[4].ToString();
                    }
                    else
                    {
                        tbxNomSalle.Text = "";
                        tbxTypeSalle.Text = "";
                        tbxSurfaceSalle.Text = "";
                        tbxCapaciteSalle.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez sélectionner une salle");
                }
            }
            catch
            {

            }
        }
    }
}
