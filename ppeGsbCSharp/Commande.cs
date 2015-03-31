using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace ppeGsbCSharp
{
    class Commande
    {
        private string date;
        private string num;
        private string etat;
        private string etatTotal;
        private int unClient;
        //constructeur
        public Commande(string etattotal){
            etatTotal = etattotal;
        }
        public Commande(string unNum, string uneDate, string unEtat, int unClientId)
        {
            date = uneDate;
            num = unNum;
            etat = unEtat;
            unClient = unClientId;
        }
        //methode Get/Set
        public int getUnClientId()
        {
            return unClient;
        }
        public string getEtatTotal()
        {
            return etatTotal;
        }
        public string getDate()
        {
            return date;
        }
        public string getNum()
        {
            return num;
        }
        public string getEtat()
        {
            return etat;
        }
        //procedure modification d'un etat
        public void updateEtat(int letat,string nomEtat,string num)
        {
            etat = nomEtat;
            DAOCommande.updateCommande(letat,num);
            MessageBox.Show("Update éffèctué");
        }
        //procedure ajout d'une commande
        public static void ajoutComandeListe(int IdClient, string unNum, string uneDate, int unEtat)
        {
            DAOCommande.insertCommande(IdClient,unNum, uneDate, unEtat);
            
        }


    }
}
