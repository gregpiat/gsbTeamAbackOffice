using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ppeGsbCSharp
{
    class commandeListe
    {
        private int leNumProduit;
        private int quantite;
        private string numCommande;

        //constructeur
        public commandeListe(string numDeLaCommande,int leProduit, int laQuantite )
        {
            leNumProduit = leProduit;
            quantite = laQuantite;
            numCommande = numDeLaCommande;
        }

        //methode Get/Set
        public int getleNumProduit()
        {
            return leNumProduit;
        }
        public int getQuantite()
        {
            return quantite;
        }
        public string getNumCommande()
        {
            return numCommande;
        }
        //procedure ajout d'une ligne
        public static void ajoutComandeListe(string unNum, int quantite, int numProduit)
        {
            DAOCommande.insertCommandeLigne(unNum, quantite, numProduit);
        }
    }
}
