using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ppeGsbCSharp
{
    class daoFactory
    {
        public SqlConnection connexionBDD;
        public string serveur;
        public string bdd;
        public string user;
        public string mdp;

        public daoFactory()
        {
            Initialize();
        }

        public void Initialize()
        {
            // Informations de connexion à la base de données
            serveur = "172.17.21.10";
            bdd = "TeamA2";
            user = "piat";
            mdp = "btssio-2015";
            

            //Test de connexion au serveur DNS de Google
            bool pingable = false;
            Ping pinger = new Ping();

            try
            {
                PingReply reply = pinger.Send("8.8.8.8");

                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                MessageBox.Show("Erreur de connexion à internet. Veuillez vous connecter et réessayer.");
                Application.Exit();
            }

            //Test de connexion au serveur de base de données sur le réseau local
            try
            {
                PingReply reply = pinger.Send(serveur);

                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                MessageBox.Show("Erreur de connexion au réseau local. Le serveur de base de données est introuvable.");
                Application.Exit();
            }


            //Création de la connexion à la base de données.
            string connexionString = "SERVER=" + serveur + ";" + "DATABASE=" +
            bdd + ";" + "UID=" + user + ";" + "PASSWORD=" + mdp + ";";

            connexionBDD = new SqlConnection(connexionString);
        }


        //Ouverture de la connexion à la base de données
        public bool OuvrirConnexion()
        {
            try
            {
                connexionBDD.Open();
                return true;
            }
            catch (SqlException ex)
            {

                    MessageBox.Show("Erreur : " + ex.ToString());
                    return false;
            }
           
        }

        //Fermeture de la connexion à la base de données
        public bool CloseConnection()
        {
            try
            {
                connexionBDD.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
