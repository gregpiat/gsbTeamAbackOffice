using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

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
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur. Veuillez contacter l'administrateur");
                        break;

                    case 1045:
                        MessageBox.Show("Le couple nom d'utilisateur/mot de passe est invalide");
                        break;
                }
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
        //execution requete
        public SqlDataReader execSql(String req)
        {
            SqlCommand maCommand;
            maCommand = new SqlCommand(req);
            maCommand.Connection = connexionBDD;
            SqlDataReader reader = maCommand.ExecuteReader();
            return reader;

        }
    }
}
