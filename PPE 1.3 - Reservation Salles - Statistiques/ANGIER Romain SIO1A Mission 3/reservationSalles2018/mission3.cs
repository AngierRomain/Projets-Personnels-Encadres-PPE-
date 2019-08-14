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
    public partial class mission3 : Form
    {
        DataTable tableSalles = M2LReservationSalles.reservationsSallesDataSet.Tables["Salles"];
        DataTable tableReservants = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservants"];
        DataTable tableReservations = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservations"];

        DataRelation reservantsReservations = M2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoin"];
        DataRelation sallessReservations = M2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoin2"];

        public mission3()
        {
            InitializeComponent();
        }
        String[,] tabReservations;
        String[,] tabSalles;
        String[] tabMois;
        private void statistiques_Load(object sender, EventArgs e)
        {
            int nbLignesReservations, nbColonnesReservations = 5, nbLignesSalles, nbColonnesSalles = 6, i, nbReservations;

            nbLignesReservations = reservantsReservations.ChildTable.Rows.Count;
            tabReservations = new String[nbLignesReservations, nbColonnesReservations];

            nbLignesSalles = tableSalles.Rows.Count;
            tabSalles = new String[nbLignesSalles, nbColonnesSalles];

            /* Du coup pour finir voir cahier de brouillon + refaire un dgv avec le type de salle le mois le nombre de résevation et lier à une combobox
             * Combobox : choisir type de salle valider et ca rempli le dgvResultats*/
            nbReservations = 0;
            i = 0;
            foreach (DataRow reservationsLigne in reservantsReservations.ChildTable.Rows)
            {
                tabReservations[i, 0] = reservationsLigne.GetParentRow(sallessReservations)["typeSalle"].ToString();
                tabReservations[i, 1] = Convert.ToDateTime(reservationsLigne["dateReservation"]).ToString("MMMM");
                tabReservations[i, 2] = Convert.ToDateTime(reservationsLigne["dateReservation"]).ToString("yyy");
                tabReservations[i, 3] = nbReservations.ToString();

                i++;
            }

            i = 0;
            foreach (DataRow sallesLigne in tableSalles.Rows)
            {
                tabSalles[i, 0] = sallesLigne["typeSalle"].ToString(); ;

                i++;
            }

            const byte NB_COL = 5;

            dgvStatistiques.ColumnCount = NB_COL;

            dgvStatistiques.ColumnHeadersVisible = true;
            dgvStatistiques.Columns[3].HeaderText = "Nombre de Réservations";
            dgvStatistiques.Columns[1].HeaderText = "Mois";
            dgvStatistiques.Columns[2].HeaderText = "Année";
            dgvStatistiques.Columns[0].HeaderText = "Type Salle";


            dgvStatistiques.ReadOnly = true;
            dgvStatistiques.RowHeadersVisible = false;



            for (i = 0; i < dgvStatistiques.ColumnCount; i++)
            {
                dgvStatistiques.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


            for (i = 0; i < tabReservations.GetLength(0); i++)
            {
                dgvStatistiques.Rows.Add();
                for (int j = 0; j < tabReservations.GetLength(1); j++)
                {
                    dgvStatistiques[j, i].Value = tabReservations[i, j];
                }
            }


            int moisActuel = DateTime.Now.Month;
            dgvResultats.ColumnCount = 2;


            for (i = 0; i < moisActuel - 1; i++)
            {
                dgvResultats.Rows.Add();
                dgvResultats[0, i].Value = i + 1;



            }
        }
        private void cbxMois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Je n'ai pas pu tester la partie ci-dessous à cause de l'erreur que vous trouverez sous la forme d'une capture dans le dossier de la solution.
        private void btnValider_Click(object sender, EventArgs e)
        {
            /****************************************************************************************************************************
             * Le but de cet algorithme est de parcourir le type de salle et de dire pour chaque mois combien de réservations il y a eu.*
             * *************************************************************************************************************************/
            //boucle pour TypeSalle
            for(int i=0; i< tabSalles.GetLength(0); i++)
            {
                String typeSalle = tabSalles[i, 0];
                //boucle pour les mois
                for(int j = 0; j < tabMois.Length; j++)
                {
                    String[] mois = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
                    int nbResa = 0;
                    //boucle pour les réservations
                    for(int k =0; k < tabReservations.GetLength(0); i++)
                    {
                        if(tabReservations[k,1] == mois[k] && nbResa != 0)
                        {
                            nbResa++;
                            dgvResultats.Rows.Add(typeSalle, mois, nbResa);
                        }
                    }
                }
            }
        }
    }
}