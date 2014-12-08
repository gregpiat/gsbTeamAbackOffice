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
        SqlConnection connexionBDD;

        public daoFactory()
        {
            Initialize();
        }

        public void Initialize(){
            connexionBDD = new SqlConnection("user id=piat;" +
                                       "password=btssio-2015;server=172.17.21.10;" +
                                       "Trusted_Connection=yes;" +
                                       "database=gbsTeamA; " +
                                       "connection timeout=15");
        }

        public bool ouvrirConnexion(){
            try{
                connexionBDD.Open();
                return true;
             }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur. Contacter l'administrateur");
                        break;

                    case 1045:
                        MessageBox.Show("utilisateur/mdp invalide");
                        break;
                }
                return false;
            }

        }
    }
}
