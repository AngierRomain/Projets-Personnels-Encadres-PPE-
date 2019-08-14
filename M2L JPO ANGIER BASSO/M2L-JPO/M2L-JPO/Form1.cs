using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2L_JPO
{
    public partial class frmJPO : Form
    {
        public frmJPO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enregistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "Enregistrements")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                LigueEnregistrer Fligue = new LigueEnregistrer();
                Fligue.MdiParent = this;
                Fligue.WindowState = FormWindowState.Maximized;
                Fligue.Show();

            }
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "Inscriptions")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                LigueInscription Fligue = new LigueInscription();
                Fligue.MdiParent = this;
                Fligue.WindowState = FormWindowState.Maximized;
                Fligue.Show();

            }
        }

        private void enregistrementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "Enregistrements")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                MembreEnregistrer Fligue = new MembreEnregistrer();
                Fligue.MdiParent = this;
                Fligue.WindowState = FormWindowState.Maximized;
                Fligue.Show();

            }
        }

        private void inscriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Text != "Enregistrements")
            {
                this.ActiveMdiChild.Close();
            }

            if (this.ActiveMdiChild == null)
            {
                MembreInscription Fligue = new MembreInscription();
                Fligue.MdiParent = this;
                Fligue.WindowState = FormWindowState.Maximized;
                Fligue.Show();

            }
        }
    }
}
