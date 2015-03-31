using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeGsbCSharp
{
    class Visite
    {
        Client client;
        String date;
        String compteRendu;
        String heure;

        public Visite(Client unClient, String uneDate,String uneHeure, String unCompteRendu){
            client = unClient;
            date = uneDate;
            compteRendu = unCompteRendu;
            heure = uneHeure;
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
