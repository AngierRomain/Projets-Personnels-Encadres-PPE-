//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace reservationSalles2018
//{
//    public partial class statistiques : Form
//    {
//        DataTable tableSalles = M2LReservationSalles.reservationsSallesDataSet.Tables["Salles"];
//        DataTable tableReservants = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservants"];
//        DataTable tableReservations = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservations"];

//        DataRelation reservantsReservations = M2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoin"];
//        DataRelation sallessReservations = M2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoin2"];

//        public statistiques()
//        {
//            InitializeComponent();
//        }

//        private void statistiques_Load(object sender, EventArgs e)
//        {
//            int nbLignesReservations, nbColonnesReservations = 8, nbLignesSalles , nbColonnesSalles = 6 , i;
//            String[,] tabReservations;
//            String[,] tabSalles;

//            nbLignesReservations = reservantsReservations.ChildTable.Rows.Count;
//            tabReservations = new String[nbLignesReservations, nbColonnesReservations];

//            nbLignesSalles = tableSalles.Rows.Count;
//            tabSalles = new String[nbLignesSalles, nbColonnesSalles];


//            i = 0;
//            foreach (DataRow reservationsLigne in reservantsReservations.ChildTable.Rows)
//            {
//                tabReservations[i, 0] = reservationsLigne.GetParentRow(reservantsReservations)["nomReservant"].ToString();
//                tabReservations[i, 1] = Convert.ToDateTime(reservationsLigne["dateReservation"]).ToString("MMMM");
//                tabReservations[i, 2] = Convert.ToDateTime(reservationsLigne["dateReservation"]).ToString("yyy");
//                tabReservations[i, 3] = reservationsLigne["plageReservation"].ToString();
//                tabReservations[i, 4] = reservationsLigne["idSalle"].ToString();
//                tabReservations[i, 5] = reservationsLigne.GetParentRow(sallessReservations)["nomSalle"].ToString();
//                tabReservations[i, 6] = reservationsLigne.GetParentRow(sallessReservations)["prixLocationSalle"].ToString();
//                tabReservations[i, 7] = reservationsLigne.GetParentRow(sallessReservations)["typeSalle"].ToString();
//                i++;
//            }

//            i = 0;
//            foreach (DataRow sallesLigne in tableSalles.Rows)
//            {
//                tabSalles[i, 0] = sallesLigne["idSalle"].ToString();
//                tabSalles[i, 1] = sallesLigne["nomSalle"].ToString(); ;
//                tabSalles[i, 2] = sallesLigne["typeSalle"].ToString(); ;
//                tabSalles[i, 3] = sallesLigne["surfaceSalle"].ToString();
//                tabSalles[i, 4] = sallesLigne["capaciteSalle"].ToString();
//                tabSalles[i, 5] = sallesLigne["prixLocationSalle"].ToString();
//                i++;


//            }

//            const byte NB_COL = 8;


//            dgvStatistiques.ColumnCount = NB_COL;

//            dgvStatistiques.ColumnHeadersVisible = true;
//            dgvStatistiques.Columns[0].HeaderText = "Reservant";
//            dgvStatistiques.Columns[1].HeaderText = "Mois";
//            dgvStatistiques.Columns[2].HeaderText = "Année";
//            dgvStatistiques.Columns[3].HeaderText = "Plage";
//            dgvStatistiques.Columns[4].HeaderText = "Id Salle";
//            dgvStatistiques.Columns[5].HeaderText = "Nom Salle";
//            dgvStatistiques.Columns[6].HeaderText = "Prix";
//            dgvStatistiques.Columns[7].HeaderText = "Type Salle";



//            dgvStatistiques.ReadOnly = true;
//            dgvStatistiques.RowHeadersVisible = false;




//            for (i = 0; i < dgvStatistiques.ColumnCount; i++)
//            {
//                dgvStatistiques.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

//            }


//            for (i = 0; i < tabReservations.GetLength(0); i++)
//            {
//                dgvStatistiques.Rows.Add();
//                for (int j = 0; j < tabReservations.GetLength(1); j++)
//                {
//                    dgvStatistiques[j, i].Value = tabReservations[i, j];
//                }
//            }

//        }

//        private void dgvStatistiques_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//    }
//}
