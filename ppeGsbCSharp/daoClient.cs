using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ppeGsbCSharp
{
    class daoClient
    {

        public List<Client> recupererLesClients()
        {
            List<Client> tousLesClients = new List<Client>();
            
            daoFactory monDaoFactory = new daoFactory();
            monDaoFactory.OuvrirConnexion();

            SqlCommand maSqlCommand = new SqlCommand("SELECT * FROM dbo.personneClient;", monDaoFactory.connexionBDD);
            SqlDataReader recupClientsDR = maSqlCommand.ExecuteReader();
            if (recupClientsDR.HasRows)
            {
                while (recupClientsDR.Read())
                {
                    Client unClient = new Client(recupClientsDR.GetInt32(0),
                                                 recupClientsDR.GetString(1).Trim(), 
                                                 recupClientsDR.GetString(2).Trim(),
                                                 recupClientsDR.GetString(3).Trim(), 
                                                 recupClientsDR.GetString(4).Trim(),
                                                 recupClientsDR.GetString(5).Trim(),
                                                 recupClientsDR.GetString(6).Trim(),
                                                 recupClientsDR.GetString(7).Trim(),
                                                 recupClientsDR.GetInt32(8),
                                                 recupClientsDR.GetString(9).Trim());
                    tousLesClients.Add(unClient);
                }
            }
            else
            {
                MessageBox.Show("Aucune valeur trouvée");
            }

            return tousLesClients;
        }


        public static void modifierClient(int unId, String unNom, String unPrenom, String uneRaison,
            String uneAdresse, String unCp, String uneVille, int unType, String unMail, String unTelephone)
        {
            try
            {
                unNom = "\'" + unNom + "\'";
                unPrenom = "\'" + unPrenom + "\'";
                uneRaison = "\'" + uneRaison + "\'";
                uneVille = "\'" + uneVille + "\'";
                uneAdresse = "\'" + uneAdresse + "\'";
                unMail = "\'" + unMail + "\'";
                unCp = "\'" + unCp + "\'";

                String requete = "UPDATE dbo.personneClient SET dbo.personneClient.nom = " + unNom + 
                    ", dbo.personneClient.prenom =" + unPrenom + 
                    ", dbo.personneClient.raisonSocial =" + uneRaison + 
                    ", dbo.personneClient.ville =" + uneVille + 
                    ", dbo.personneClient.adresse =" + uneAdresse + 
                    ", dbo.personneClient.cp =" + unCp +
                    ", dbo.personneClient.email = " + unMail +
                    ", dbo.personneClient.idTypeProfessionel =" + unType +
                    ", dbo.personneClient.telephone = " + unTelephone + 
                    " WHERE dbo.personneClient.idClient =" + unId + ";";

                daoFactory monDaoFactory = new daoFactory();
                monDaoFactory.OuvrirConnexion();
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory.connexionBDD);
                maSqlCommand.ExecuteReader();
            }
            catch (SqlException exe)
            {
                MessageBox.Show("Erreur rencontrée : " + exe.ToString());
            }
        }


        // MODIFIER LA STRUTURE DE LA BASE POUR AJOUTER LES CHAMPS MANQUANTS
        public static void ajouterClient(/*int unId,*/ String unNom, String unPrenom, String uneRaison,
            String uneAdresse, String unCp, String uneVille, int unType, String unMail, String unTelephone)
        {
            try
            { 
                unNom = "\'" + unNom + "\'";
                unPrenom = "\'" + unPrenom + "\'";
                uneRaison = "\'" + uneRaison + "\'";
                uneVille = "\'" + uneVille + "\'";
                uneAdresse = "\'" + uneAdresse + "\'";
                unMail = "\'" + unMail + "\'";
                unCp = "\'" + unCp + "\'";

                String requete = "INSERT INTO dbo.personneClient(dbo.personneClient.nom, dbo.personneClient.prenom, dbo.personneClient.raisonSocial, dbo.personneClient.ville, dbo.personneClient.adresse, dbo.personneClient.cp, dbo.personneClient.email, dbo.personneClient.idTypeProfessionel, dbo.personneClient.telephone) VALUES("
                    /*+ unId + ", "*/
                    + unNom + ", "
                    + unPrenom + ", " 
                    + uneRaison + ", " 
                    + uneVille + ", "
                    + uneAdresse + ", "
                    + unCp + ", " 
                    + unMail + ", " 
                    + unType +", "
                    + unTelephone +");";

                daoFactory monDaoFactory = new daoFactory();
                monDaoFactory.OuvrirConnexion();
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory.connexionBDD);
                maSqlCommand.ExecuteReader();
            }
            catch(SqlException exe)
            {
                MessageBox.Show("Erreur rencontrée : " + exe.ToString());
            }


        }

        // Demande de plusieurs informations pour plus de sécurité (ne pas pouvoir supprimer uniquement avec l'ID)
        public static void supprimerClient(int unId, String unNom, String unPrenom)
        {
            try
            {
                unNom = "\'" + unNom + "\'";
                unPrenom = "\'" + unPrenom + "\'";

                String requete = "DELETE FROM dbo.personneClient WHERE idClient = " + unId + " AND nom = " + unNom + " AND prenom = " + unPrenom + ";";

                daoFactory monDaoFactory = new daoFactory();
                monDaoFactory.OuvrirConnexion();
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory.connexionBDD);
                maSqlCommand.ExecuteReader();
            }
            catch (SqlException exe)
            {
                MessageBox.Show("Erreur rencontrée : " + exe.ToString());
            }
        }


        public String trouverNomProfessionParId(int unId)
        {
            String resultat = "";

            daoFactory monDaoFactory = new daoFactory();
            monDaoFactory.OuvrirConnexion();

            SqlCommand maSqlCommand = new SqlCommand("SELECT nom FROM dbo.typeProfessionnel WHERE idTypeProf ="+unId+";", monDaoFactory.connexionBDD);
            SqlDataReader recupClientsDR = maSqlCommand.ExecuteReader();
            if (recupClientsDR.HasRows)
            {
                while (recupClientsDR.Read())
                {
                    resultat = recupClientsDR.GetString(0);
                }
            }
            else
            {
                resultat = "Aucun résultat";
            }  
            return resultat;
        }

        /*public int trouverIdProfessionnelParNomProfession(String unNom)
        {
            int resultat = -1;

            daoFactory monDaoFactory2 = new daoFactory();
            monDaoFactory2.OuvrirConnexion();

            SqlCommand maSqlCommand2 = new SqlCommand("SELECT idTypeProf FROM dbo.typeProfessionnel WHERE nom ="+unNom+";", monDaoFactory2.connexionBDD);
            SqlDataReader recupClientsDR2 = maSqlCommand2.ExecuteReader();
            if (recupClientsDR2.HasRows)
            {
                while (recupClientsDR2.Read())
                {
                    resultat = recupClientsDR2.GetInt32(0);
                }
            }
            else
            {
                    resultat = -1;
            }
            return resultat;
        }
         * */

        public List<String> chargerLesTypesProfession(String unNom)
        {
            List<String> toutesLesProfessions = new List<String>();



            return toutesLesProfessions;
        }

        public void ajouterVisite(int unIdClient, String uneDate, String unCompteRendu, String unCreateur)
        {
            try
            {
                String requete = "INSERT INTO dbo.visite(idPersonne, date, createur, compterendu) VALUES(" + unIdClient + ", " + uneDate + ", " + unCreateur + ", " + unCompteRendu + "); ";
                daoFactory monDaoFactory = new daoFactory();
                monDaoFactory.OuvrirConnexion();
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory.connexionBDD);
                maSqlCommand.ExecuteReader();
            }
            catch (SqlException exe)
            {
                MessageBox.Show("Erreur rencontrée lors de l'ajout d'une visite : " + exe.ToString());
            }
        
        
        }
    }
}