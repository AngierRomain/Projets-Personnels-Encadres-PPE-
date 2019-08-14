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
    public partial class factures : Form
    {
        DataTable tableSalles = M2LReservationSalles.reservationsSallesDataSet.Tables["Salles"];
        DataTable tableReservants = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservants"];
        DataTable tableReservations = M2LReservationSalles.reservationsSallesDataSet.Tables["Reservations"];

        DataRelation reservantsReservations = M2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoin"];
        DataRelation sallessReservations = M2LReservationSalles.reservationsSallesDataSet.Relations["EquiJoin2"];

        public factures()
        {
            InitializeComponent();
        }

        private void factures_Load(object sender, EventArgs e)
        {
            int nbLignesReservations, nbColonnesReservations = 8, i;
            String[,] tabReservations;
           

            nbLignesReservations = reservantsReservations.ChildTable.Rows.Count;
            tabReservations = new String[nbLignesReservations, nbColonnesReservations];

           

            i = 0;
            foreach (DataRow reservationsLigne in reservantsReservations.ChildTable.Rows)
            {
                tabReservations[i, 0] = reservationsLigne.GetParentRow(reservantsReservations)["nomReservant"].ToString();
                tabReservations[i, 1] = Convert.ToDateTime(reservationsLigne["dateReservation"]).ToString("MMMM");
                tabReservations[i, 2] = Convert.ToDateTime(reservationsLigne["dateReservation"]).ToString("yyy");
                tabReservations[i, 3] = reservationsLigne["plageReservation"].ToString();
                tabReservations[i, 4] = reservationsLigne["idSalle"].ToString();
                tabReservations[i, 5] = reservationsLigne.GetParentRow(sallessReservations)["nomSalle"].ToString();
                tabReservations[i, 6] = reservationsLigne.GetParentRow(sallessReservations)["prixLocationSalle"].ToString();
                tabReservations[i, 7] = reservationsLigne.GetParentRow(sallessReservations)["typeSalle"].ToString();
                i++;
            }

           





            const byte NB_COL = 8;
          

            dgvFactures.ColumnCount = NB_COL;

            dgvFactures.ColumnHeadersVisible = true;
            dgvFactures.Columns[0].HeaderText = "Reservant";
            dgvFactures.Columns[1].HeaderText = "Mois";
            dgvFactures.Columns[2].HeaderText = "Année";
            dgvFactures.Columns[3].HeaderText = "Plage";
            dgvFactures.Columns[4].HeaderText = "Id Salle";
            dgvFactures.Columns[5].HeaderText = "Nom Salle";
            dgvFactures.Columns[6].HeaderText = "Prix";
            dgvFactures.Columns[7].HeaderText = "Type Salle";



            dgvFactures.ReadOnly = true;
            dgvFactures.RowHeadersVisible = false;




            for ( i = 0; i < dgvFactures.ColumnCount; i++)
            {
                dgvFactures.ColumnHeadersDefaultCellStyle.Alignment =   DataGridViewContentAlignment.MiddleCenter;

            }


            for(i =0; i < tabReservations.GetLength(0); i++)
            {
                dgvFactures.Rows.Add();
                for(int j = 0; j < tabReservations.GetLength(1); j++)
                {
                    dgvFactures[j, i].Value = tabReservations[i, j];
                }
            }

           

        }
    }
}
