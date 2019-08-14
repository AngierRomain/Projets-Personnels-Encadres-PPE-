using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace reservationSalles2018
{
    public partial class reservations : Form
    {
        //Initialisation des tableaux
        int indice = 0;
        DateTime debutSemaineAffichee;
        DataTable tableSalles;
        DataTable tableReservants;
        DataTable tableReservations;
        bool loadOK = false;
      

       

        public reservations()
        {
            InitializeComponent();
            tableSalles = M2LReservationSalles.reservationsSallesDataSet.Tables["Salles"];
            tableReservants = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservants"];
            tableReservations = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservations"];
        }

        public void reservationsSemaineSalle(DateTime uneDate, int uneSalle)
        {
            //initialisation des variables
            string filtre, dateDebutTexte, dateFinTexte;
            DateTime dateFinSemaine;

            dateFinSemaine = uneDate.AddDays(4);
            dateDebutTexte = uneDate.ToString("MM/dd/yyyy");
            dateFinTexte = dateFinSemaine.ToString("MM/dd/yyyy");
            filtre = "dateReservation >= # " + dateDebutTexte + "# and dateReservation <= #" + dateFinTexte + "# and idSalle = " + uneSalle;

            tableReservations.DefaultView.RowFilter = filtre;
        }


        public void afficherReservations()
        {
            //Initialisation des variables
            DateTime dateDebutSemaine;
            int idSalle, index;
            byte colonne, ligne;
            dateDebutSemaine = Convert.ToDateTime(cbxSemaines.SelectedItem.ToString().Substring(0, 10));
            idSalle = Convert.ToInt32(tableSalles.Rows[cbxSallesReservation.SelectedIndex].ItemArray[0]);
            reservationsSemaineSalle(dateDebutSemaine, idSalle);

            String reservationResevant;

            
            if (dgvSemaine.RowCount > 0){
                for (int i = 0; i < 5; i++)
                {
                    dgvSemaine[i, 0].Value = null;
                    dgvSemaine[i, 1].Value = null;
                }

            }
 
            tableReservants.DefaultView.Sort = "idReservant asc";

            //Pour chaque 
            foreach (DataRowView ligneTab in tableReservations.DefaultView)
            {
                if (ligneTab["plageReservation"].ToString() == "Matin")
                {
                    ligne = 0;
                }
                else
                {
                    ligne = 1;
                }

                //Intervalle de temps Date reservation - date debut semaine
                TimeSpan ts = Convert.ToDateTime(ligneTab["dateReservation"]) - dateDebutSemaine;

              

                colonne = Convert.ToByte(ts.Days);
                index = tableReservants.DefaultView.Find(ligneTab["idReservant"]);

                reservationResevant = null;

                reservationResevant = "Réservation n° : " +ligneTab["idReservation"].ToString() + "\r\n";
                reservationResevant += tableReservants.DefaultView[index]["nomReservant"].ToString();

               

                dgvSemaine[colonne, ligne].Value = reservationResevant;

            }

        

           

        }


        private void reservations_Load(object sender, EventArgs e)
        {
            
            cbxSallesReservation.DataSource = tableSalles;
            cbxSallesReservation.DisplayMember = tableSalles.Columns[1].ToString();
            cbxSallesReservation.ValueMember = tableSalles.Columns[0].ToString();


            cbxReservants.DataSource = tableReservants;
            cbxReservants.DisplayMember = tableReservants.Columns[1].ToString();
            cbxReservants.ValueMember = tableReservants.Columns[0].ToString();


            DateTime premierLundi, debutSemaine, aujourdhui, debutAnnee;

            premierLundi = new DateTime();
            debutSemaine = new DateTime();
            debutAnnee = new DateTime();

            dgvSemaine.RowCount = 2;
            dgvSemaine.ColumnCount = 5;
            dgvSemaine.Rows[0].Height = 100;
            dgvSemaine.Rows[1].Height = 100;
            dgvSemaine.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSemaine.RowHeadersVisible = false;
            dgvSemaine.MultiSelect = false;

            dgvSemaine.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSemaine.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            for (int i = 0; i < 5; i++)
            {
                dgvSemaine.Columns[i].Width = 128;
        
            }



            aujourdhui = DateTime.Now;
            debutAnnee = Convert.ToDateTime("1-1-" + aujourdhui.Year.ToString());
            byte jourSem = Convert.ToByte(debutAnnee.DayOfWeek);
            premierLundi = debutAnnee.AddDays(-(jourSem - 1));

            debutSemaine = premierLundi;

            for (int i = 0; i <= 103; i++)
            {
                cbxSemaines.Items.Add(debutSemaine.ToShortDateString() + " - " + debutSemaine.AddDays(4).ToShortDateString());

                if (DateTime.Today >= debutSemaine && DateTime.Today <= debutSemaine.AddDays(6))
                {
                    indice = i;
                }


                debutSemaine = debutSemaine.AddDays(7);
            }

            cbxSemaines.SelectedIndex = indice;
            dgvSemaine.CurrentCell = null;

            loadOK = true;

        }

        private void cbxSemaines_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cbxSemaines.SelectedIndex;



            debutSemaineAffichee = Convert.ToDateTime(cbxSemaines.SelectedItem.ToString().Substring(0, 10));

            for (int i = 0; i < 5; i++)
            {
                dgvSemaine.Columns[i].HeaderText = debutSemaineAffichee.AddDays(i).ToShortDateString();
            }
              if (cbxSallesReservation.SelectedIndex != -1)
              {
                  afficherReservations();
              }
        }

        private void btnSemaineSuivante_Click(object sender, EventArgs e)
        {
            tbxDateReservation.Text = null;
            tbxPlageReservation.Text = null;
            rtbCommentaires.Text = null;
            dgvSemaine.CurrentCell = null;

            if (indice < 103)
            {
                indice++;
                cbxSemaines.SelectedIndex = indice;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private void btnSemainePrecedente_Click(object sender, EventArgs e)
        {
            tbxDateReservation.Text = null;
            tbxPlageReservation.Text = null;
            rtbCommentaires.Text = null;
            dgvSemaine.CurrentCell = null;

            if (indice > 0)
            {
                indice--;
                cbxSemaines.SelectedIndex = indice;
            }
            else
            {
                SystemSounds.Beep.Play();
            }
            
        }

        private void btnSupprimerReservation_Click(object sender, EventArgs e)
        {
            if (dgvSemaine.SelectedCells.Count == 1 && dgvSemaine.SelectedCells[0].Value != null)
            {
                int idReservation;
                string contenuCellule = dgvSemaine.SelectedCells[0].Value.ToString();

                contenuCellule = contenuCellule.Substring(16,contenuCellule.IndexOf("Ligue")-16) ;

                idReservation = Convert.ToInt16(contenuCellule);

                dbConnexion.supprimerReservation(idReservation);

                dbConnexion.miseJourDataSet();
                afficherReservations();

                MessageBox.Show("La réservation à été supprimée.");

            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une plage  !!!");
            }

           
        }

        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {
            int idSalle, idReservant;
            String plageReservee;
            DateTime dateReservation;

          
            if(cbxSallesReservation.SelectedIndex != -1 && cbxReservants.SelectedIndex != -1 && dgvSemaine.SelectedCells.Count == 1 && dgvSemaine.SelectedCells[0].Value == null)
            {
                idSalle = (int)cbxSallesReservation.SelectedValue;

                idReservant = (int)cbxReservants.SelectedValue;


                if (dgvSemaine.CurrentCell.RowIndex == 0)
                {
                    plageReservee = "Matin";
                }
                else
                {
                    plageReservee = "Après midi";
                }


                dateReservation = Convert.ToDateTime(dgvSemaine.Columns[dgvSemaine.CurrentCell.ColumnIndex].HeaderText);


                dbConnexion.ajouterReservation(dateReservation, plageReservee, idReservant, idSalle);

                dbConnexion.miseJourDataSetRéservations();
                afficherReservations();
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une salle, un reservant et une plage libre !!!");
            }
            

           
        }

        private void cbxSallesReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
            if (cbxSallesReservation.SelectedIndex != -1 && cbxSemaines.SelectedIndex != -1 && loadOK == true)
            {
                              
                afficherReservations();
              
            }
        }

        private void reservations_Leave(object sender, EventArgs e)
        {
            loadOK = false;
        }

        private void dgvSemaine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
