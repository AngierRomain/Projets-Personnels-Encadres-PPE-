using System.Data;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace reservationSalles2018
{
    class dbConnexion
    {
        private static OleDbConnection connex = new System.Data.OleDb.OleDbConnection();
        private static string connexString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=..\..\..\reservationSalles.accdb";
        private static DataSet reservationsDataSet;
        private static OleDbDataAdapter sallesDataAdapter;
        private static OleDbDataAdapter reservantsDataAdapter;
        private static OleDbDataAdapter reservationsDataAdapter;

        public static OleDbConnection connexionBase()
        {
            try
            {
                connex.ConnectionString = connexString;
                connex.Open();
                return connex;
            }
            catch
            {
                return null;

            }
        }


        public static OleDbDataReader GetDataReader(string uneRequete)
        {
            try
            {
                OleDbCommand oleCommande = new OleDbCommand(uneRequete, connex);
                OleDbDataReader reader = oleCommande.ExecuteReader();
                return reader;
            }
            catch
            {
                return null;

            }
        }


        public static void setDataSet()
        {
            sallesDataAdapter = new OleDbDataAdapter();
            reservantsDataAdapter = new OleDbDataAdapter();
            reservationsDataAdapter = new OleDbDataAdapter();
          

            string sallesRequete = "select * from salles";
            string reservantsRequete = "select * from reservants";
            string reservationsRequete = "select * from reservations";
          

            OleDbCommand sallesCommande;
            OleDbCommand reservantsCommande;
            OleDbCommand reservationsCommande;
           

            OleDbConnection maConnex = connexionBase();

            sallesCommande = new OleDbCommand(sallesRequete);
            sallesCommande.Connection = maConnex;
            reservantsCommande = new OleDbCommand(reservantsRequete);
            reservantsCommande.Connection = maConnex;
            reservationsCommande = new OleDbCommand(reservationsRequete);
            reservationsCommande.Connection = maConnex;

          

            sallesDataAdapter.SelectCommand = sallesCommande;
            reservantsDataAdapter.SelectCommand = reservantsCommande;
            reservationsDataAdapter.SelectCommand = reservationsCommande;

          

           // DataSet 
            reservationsDataSet = new DataSet();
            sallesDataAdapter.Fill(reservationsDataSet, "salles");
            reservantsDataAdapter.Fill(reservationsDataSet, "reservants");
            reservationsDataAdapter.Fill(reservationsDataSet, "reservations");

            

            DataTable tableSalles = reservationsDataSet.Tables["salles"];
            tableSalles.Columns[0].AutoIncrement = true;

            DataTable tableReservants = reservationsDataSet.Tables["reservants"];
            tableReservants.Columns[0].AutoIncrement = true;

            DataTable tableReservations = reservationsDataSet.Tables["reservations"];
            tableReservations.Columns[0].AutoIncrement = true;


            DataRelation reservantsReservations = new DataRelation("EquiJoin", tableReservants.Columns["idReservant"], tableReservations.Columns["idReservant"]);
            reservationsDataSet.Relations.Add(reservantsReservations);


            DataRelation sallesReservations = new DataRelation("EquiJoin2", tableSalles.Columns["idSalle"], tableReservations.Columns["idSalle"]);
            reservationsDataSet.Relations.Add(sallesReservations);




            maConnex.Close();


        }


        public static DataSet getDataSet()
        {
            return reservationsDataSet;
        }



        public static void miseJourDataSet()
        {
            reservationsDataSet.Clear();
            sallesDataAdapter.Fill(reservationsDataSet, "Salles");
            reservantsDataAdapter.Fill(reservationsDataSet, "Reservants");
            reservationsDataAdapter.Fill(reservationsDataSet, "Reservations");
        }


        public static void miseJourDataSetRéservations()
        {
           
            reservationsDataAdapter.Fill(reservationsDataSet, "Reservations");
        }


        public static void ajouterSalle(string unNom, string unType, short uneSurface, short uneCapacite)
        {
            try
            {
                string uneRequete = "insert into salles (nomSalle , typeSalle, surfaceSalle , capaciteSalle) values ('" + unNom + "' , '" + unType + "' ,  " + uneSurface + " ,  " + uneCapacite + ")";
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);
            }


        }

        public static void modifierSalle(int unIdSalle, string unNom, string unType, short uneSurface, short uneCapacite)
        {
            try
            {
                string uneRequete = "update  salles set nomSalle = '" + unNom + "', typeSalle = '" + unType + "', surfaceSalle = " + uneSurface + ", capaciteSalle = " + uneCapacite + " where idSalle = " + unIdSalle;
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);
            }


        }

        public static void supprimerSalle(int unIdSalle)
        {
            try
            {
                string uneRequete = "delete from salles where idSalle = " + unIdSalle;
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);

            }
        }

        public static void ajouterReservant(string unNom, string unTelephone, string unMail)
        {
            try
            {
                string uneRequete = "insert into reservants (nomReservant , telephoneReservant, mailReservant) values ('" + unNom + "' , '" + unTelephone + "' ,  '" + unMail + "')";
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);
            }


        }

        public static void modifierReservant(int unIdReservant, string unNom, string unTelephone, string unMail)
        {
            try
            {
                string uneRequete = "update  reservants set nomReservant = '" + unNom + "', telephoneReservant = '" + unTelephone + "', mailReservant = '" + unMail + "' where idReservant = " + unIdReservant;
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);
            }


        }

        public static void supprimerReservant(int unIdReservant)
        {
            try
            {
                string uneRequete = "delete from reservants where idReservant = " + unIdReservant;
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);

            }
        }

        public static void ajouterReservation(DateTime uneDateReservation, string unePlageReservation, int unIdReservant, int unIdSalle)
        {
            try
            {
                string uneRequete = "insert into reservations (dateReservation , plageReservation ,  idReservant, idSalle) values (" + uneDateReservation.ToOADate() + " , '" + unePlageReservation + "' ,  " + unIdReservant + " ,  " + unIdSalle + ")";

                
                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);
            }


        }

        public static void supprimerReservation( int unIdReservation)
        {
            try
            {
                string uneRequete = "delete from reservations where idReservation = " + unIdReservation ;


                connexionBase();
                OleDbCommand uneCommande = new OleDbCommand(uneRequete, connex);
                uneCommande.ExecuteNonQuery();
                connex.Close();
            }
            catch (DataException de)
            {
                MessageBox.Show(de.Message);
            }


        }

    }
}
