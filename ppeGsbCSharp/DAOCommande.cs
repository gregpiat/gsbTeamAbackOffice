using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace ppeGsbCSharp
{
    class DAOCommande
    {
        //Selectionne de toute les Commandes les ajoutants à la classe commande
        public static ArrayList list()
        {
            daoFactory bdd = new daoFactory();
            SqlDataReader resultset;
            string requete = "select idCommande,date,libelleEtat,idClient from commande inner join etat on commande.idEtat=etat.idEtat";
            ArrayList resultat = new ArrayList();
            bdd.OuvrirConnexion();
            resultset = bdd.execSql(requete);
            while (resultset.Read())
            {
                resultat.Add(new Commande(resultset.GetInt32(0).ToString(), resultset.GetDateTime(1).ToString(), resultset.GetString(2),resultset.GetInt32(3)));

            }
            resultset.Close();
            bdd.CloseConnection();
            return resultat;
        }
        //Selection de toute les lignes les ajoutants à la classe commandeListe
        public static List<commandeListe> ligneCommande()
        {
            daoFactory bdd = new daoFactory();
            SqlDataReader resultset;
            string requete = "select * from dbo.ligne";
            List<commandeListe> resultat = new List<commandeListe>();
            bdd.OuvrirConnexion();
            resultset = bdd.execSql(requete);
            while (resultset.Read())
            {
                resultat.Add(new commandeListe(resultset.GetInt32(0).ToString(), resultset.GetInt32(1), resultset.GetInt32(2)));

            }
            resultset.Close();
            bdd.CloseConnection();
            return resultat;
        }
        //update de l'etat d'une commande predefini
        public static void updateCommande(int letat,string num)
        {
            daoFactory bdd = new daoFactory();
            SqlDataReader resultset;
            string requete = "update commande set idEtat='" + letat + "' where idCommande='" + num + "'";
            bdd.OuvrirConnexion();
            resultset = bdd.execSql(requete);
            resultset.Read();
            resultset.Close();
            bdd.CloseConnection();
        }
        //insertion d'un nouvelle commandeLigne
        public static void insertCommandeLigne(string unNum, int uneQuantite, int numProduit)
        {
            daoFactory bdd = new daoFactory();
            SqlDataReader resultset;
            string requete = "insert into dbo.ligne values('" + unNum + "','" + numProduit + "','" + uneQuantite + "')";
            bdd.OuvrirConnexion();
            resultset = bdd.execSql(requete);
            resultset.Read();
            resultset.Close();
            bdd.CloseConnection();
        }

        //insertion d'une nouvelle commande
        public static void insertCommande(int idClient, string unNum, string uneDate, int unEtat)
        {
            daoFactory bdd = new daoFactory();
            SqlDataReader resultset;
            string requete = "insert into dbo.commande values('" + unNum + "','" + uneDate + "','" + idClient + "','" + unEtat + "')";
            
            bdd.OuvrirConnexion();
            resultset = bdd.execSql(requete);
            resultset.Read();
            resultset.Close();
            bdd.CloseConnection();
        }
        //recuperation de tout les etat existant
        public static ArrayList recupEtat()
        {
            daoFactory bdd = new daoFactory();
            SqlDataReader resultset;
            string requete = "select libelleEtat from etat";
            ArrayList resultat = new ArrayList();
            bdd.OuvrirConnexion();
            resultset = bdd.execSql(requete);
            while (resultset.Read())
            {
                resultat.Add(new Commande(resultset.GetString(0)));
            }
            resultset.Close();
            bdd.CloseConnection();
            return resultat;
        }
    }
}
