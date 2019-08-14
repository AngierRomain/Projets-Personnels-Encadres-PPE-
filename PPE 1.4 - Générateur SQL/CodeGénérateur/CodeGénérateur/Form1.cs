using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodeGénérateur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            String ligne;
            OFD.Title = "Les fichiers texte."; //titre de la boite de dialogue
            OFD.Filter = "Fichiers texte|*.txt";// Filtre : n'affiche que les fichiers ".txt"

            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    lbxFichiers.Items.Clear();  // vider la listbox
                    StreamReader SR = new StreamReader(OFD.OpenFile()); // Ouvrir le flux en lecture
                    while ((ligne = SR.ReadLine()) != null) //lire le fichier ligne par ligne 
                    {
                        lbxFichiers.Items.Add(ligne); // copier les lignes du fichier dans la listBox
                    }
                    SR.Close(); // fermer le flux
                }
                catch
                {
                    MessageBox.Show("Erreur: Lecture du fichier impossible");
                }
            }
        }

        private void btnSFD_Click(object sender, EventArgs e)
        {
            SFD.InitialDirectory = @"C:\";
            SFD.DefaultExt = "txt";
            SFD.ShowDialog();

            if (SFD.FileName != "")
            {
                StreamWriter fsWriter = new StreamWriter(SFD.OpenFile());
                fsWriter.Write(" ");
                fsWriter.Close();
                fsWriter.Dispose();
            }

        }

        
    }
}
