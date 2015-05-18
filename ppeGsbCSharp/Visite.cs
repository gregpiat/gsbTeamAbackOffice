using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeGsbCSharp
{
    class Visite
    {
        int id;
        Client client;
        String date;
        String heure;
        String compteRendu;
        String createur;
        

        public Visite(int unId, Client unClient, String uneDate,String uneHeure, String unCompteRendu, String unCreateur){
            id = unId;
            client = unClient;
            date = uneDate;
            heure = uneHeure;
            compteRendu = unCompteRendu;
            createur = unCreateur;
        }

        #region Getters / Setters
        internal Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String CompteRendu
        {
            get { return compteRendu; }
            set { compteRendu = value; }
        }

        public String Heure
        {
            get { return heure; }
            set { heure = value; }
        }
        #endregion

    }
}
