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
    public partial class M2LReservationSalles : Form
    {

        public static DataSet reservationsSallesDataSet;
        public M2LReservationSalles()
        {
            InitializeComponent();
        }


        private void M2LReservationSalles_Load(object sender, EventArgs e)
        {
            dbConnexion.setDataSet();
            reservationsSallesDataSet = dbConnexion.getDataSet();
        }


        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "salles")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                salles Fsalles = new salles();
                Fsalles.MdiParent = this;
                Fsalles.WindowState = FormWindowState.Maximized;
                Fsalles.Show();
            }

        }


      


     

        private void réservantsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "reservants")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                reservants Freservants = new reservants();
                Freservants.MdiParent = this;
                Freservants.WindowState = FormWindowState.Maximized;
                Freservants.Show();

            }

        }

        private void réservationsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "reservations")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                reservations Freservantions = new reservations();
                Freservantions.MdiParent = this;
                Freservantions.WindowState = FormWindowState.Maximized;
                Freservantions.Show();

            }
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
