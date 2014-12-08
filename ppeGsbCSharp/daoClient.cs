using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ppeGsbCSharp
{
    class daoClient
    {
        public List<Client> tousLesClients;

        public static List<Client> recupererLesClients()
        {
            String requete = "SELECT * FROM client;";

            tousLesClients = new List<Client>();
            return tousLesClients;
        }
        public static void modifierClient(int unId, String unNom, String unCode, String uneRaison, String uneAdresse, String unType, String unTel, String unMail, DateTime uneDate){
            daoFactory.connexionBDD();
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

        public static void supprimerClient(int unId)
        {
            String requete = "DELETE FROM client WHERE id =" + unId + ";";
        }
    }
}
