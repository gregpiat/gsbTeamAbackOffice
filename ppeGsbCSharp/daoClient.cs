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
            
            daoFactory monDaoFactory1 = new daoFactory();
            monDaoFactory1.OuvrirConnexion();

            SqlCommand maSqlCommand = new SqlCommand("SELECT * FROM dbo.personneClient;", monDaoFactory1.connexionBDD);
            SqlDataReader recupClientsDR = maSqlCommand.ExecuteReader();
            if (recupClientsDR.HasRows)
            {
                while (recupClientsDR.Read())
                {
                    Client unClient = new Client(recupClientsDR.GetInt32(0),
                                                 recupClientsDR.GetString(1), 
                                                 recupClientsDR.GetString(2),
                                                 recupClientsDR.GetString(3), 
                                                 recupClientsDR.GetString(4),
                                                 recupClientsDR.GetString(5), 
                                                 recupClientsDR.GetString(6),
                                                 recupClientsDR.GetString(7),
                                                 recupClientsDR.GetInt32(8));
                    tousLesClients.Add(unClient);
                }
            }
            else
            {
                MessageBox.Show("Aucune valeur trouvée");
            }

            return tousLesClients;
        }
        public void modifierClient(int unId, String unNom, String unCode, String uneRaison, String uneAdresse, 
                                            String unType, String unTel, String unMail, DateTime uneDate){

            String requete = "UPDATE client SET (nom =" + unNom + 
                                                ", code =" + unCode + 
                                                ", raison=" + uneRaison + 
                                                "adresse=" + uneAdresse + 
                                                ", type =" + unType + 
                                                ", tel =" + unTel + 
                                                ", mail =" + unMail + 
                                                ",date =" + uneDate+
                                                ") where id ="+unId+";";
        }

        public void ajouterClient(String unNom, String unCode, String uneRaison, String uneAdresse, 
                                            String unType, String unTel, String unMail, DateTime uneDate)
        {
            String requete = "INSERT INTO client(nom, code, raison, adresse, type, tel, mail, date) VALUES(nom ="+ unNom +
                                                ", code =" + unCode +
                                                ", raison=" + uneRaison +
                                                "adresse=" + uneAdresse +
                                                ", type =" + unType +
                                                ", tel =" + unTel +
                                                ", mail =" + unMail +
                                                ",date =" + uneDate +
                                                ");";
        }

        public static void supprimerClient(int unId)
        {
            String requete = "DELETE FROM client WHERE id =" + unId + ";";
        }

        public void modifierClient(String unNom, String uneAdresse, String unTel, String unMail, String uneRaison,
                                                                            String unCode, String unType)
        {
            
        }

        public String trouverNomProfessionParId(int unId)
        {
            String resultat = "";

            daoFactory monDaoFactory1 = new daoFactory();
            monDaoFactory1.OuvrirConnexion();

            SqlCommand maSqlCommand = new SqlCommand("SELECT nom FROM dbo.typeProfessionnel WHERE idTypeProf ="+unId+";", monDaoFactory1.connexionBDD);
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
    }
}