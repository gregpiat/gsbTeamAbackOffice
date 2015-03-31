using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ppeGsbCSharp
{
    class daoVisiteur
    {/*
        public List<Visiteur> recupererLesVisiteurs()
        {
            List<Visiteur> tousLesVisiteurs = new List<Visiteur>();

            daoFactory monDaoFactory = new daoFactory();
            monDaoFactory.OuvrirConnexion();

            SqlCommand maSqlCommandV = new SqlCommand("SELECT * FROM dbo.personneVisiteur;", monDaoFactory.connexionBDD);
            SqlDataReader recupVisiteursDR = maSqlCommandV.ExecuteReader();
            if (recupVisiteursDR.HasRows)
            {
                while (recupVisiteursDR.Read())
                {
                    Visiteur unVisiteur = new Visiteur(recupVisiteursDR.GetInt32(0),
                                                 recupVisiteursDR.GetString(1),
                                                 recupVisiteursDR.GetString(2));
                    tousLesVisiteurs.Add(unVisiteur);
                }
            }
            else
            {
                MessageBox.Show("Aucune valeur trouvée");
            }

            return tousLesVisiteurs;
        }
        */
    }
}
