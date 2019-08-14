using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fichiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "..\\..\\..\\";
            string path2 = path;
            string nomFichier = "listeSIO1A.txt";
            path = path + nomFichier;
        }

        /*********************************************************
         Affiche des informations sur les disques installés sur l'ordinateur.
         **********************************************************/
        private void btnDriveInfo_Click(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
           
            foreach(DriveInfo unDrive in drives)
            {
                if (unDrive.IsReady)
                {
                    MessageBox.Show(unDrive.Name.ToString() + "  " + unDrive.DriveType.ToString() + unDrive.TotalSize.ToString() + " " + unDrive.TotalFreeSpace.ToString());
                }
                else
                {
                    MessageBox.Show(unDrive.Name.ToString() + "  " + unDrive.DriveType.ToString());
                }
               
            }

        }

        /*********************************************************
		La création d'un contrôle FolderBrowserDialog nommé FBD est nécessaire.
		Ouvre une boite de dialogue "Explorateur de répertoires"
		Récupére le chemin d'accès au répertoire sélectionné et le copie dans un TextBox.
		**********************************************************/		
        private void FBD_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                txbDossier.Text = FBD.SelectedPath;
            }

        }


        /************************************************************
		La création d'un contrôle OpenFileDialog nommé OFD est nécessaire.
		Ouvre une boite de dialogue "Explorateur de fichiers"
		Récupére le chemin d'accès au fichier sélectionné et copie son contenu (ligne par ligne) dans une ListBox.
		*************************************************************/
        private void btnOFD_Click(object sender, EventArgs e)
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

		/************************************************************
		La création d'un contrôle SaveFileDialog nommé OFD est nécessaire.
		Ouvre une boite de dialogue "Sauvegarde de fichier".
        Enregistre le contenu de la TextBox dans un fichier .txt
		*************************************************************/
        private void btnSFD_Click(object sender, EventArgs e)
        {
            SFD.InitialDirectory = @"C:\";
            SFD.DefaultExt = "txt";
            SFD.ShowDialog();

            if (SFD.FileName != "")
            {
                StreamWriter fsWriter = new StreamWriter(SFD.OpenFile());
                fsWriter.Write(tbxMonTexte.Text);
                fsWriter.Close();
                fsWriter.Dispose();
            }

        }
    }
}
