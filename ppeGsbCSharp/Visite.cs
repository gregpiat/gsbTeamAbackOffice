using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeGsbCSharp
{
    class Visite
    {
        int idClient;
        String date;
        String compteRendu;
        String createur;
        

        public Visite(int unIdClient, String uneDate, String unCompteRendu, String unCreateur){
            idClient = unIdClient;
            date = uneDate;
            compteRendu = unCompteRendu;
            createur = unCreateur;
        }

        #region Getters / Setters
        internal int Client
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public String CompteRendu
        {
            get { return compteRendu; }
            set { compteRendu = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
        #endregion

    }
}
