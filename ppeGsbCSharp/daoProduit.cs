using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ppeGsbCSharp

{
    public class daoProduit
    {
        int unNum;
        String unNom;
        String desEffets;
        String desIncompatibilites;
        String desInteractions;
        decimal unPrixHT;
        public static List<Produit> listeProduit()
        {
            daoFactory p = new daoFactory();
            p.OuvrirConnexion();
            string req = "SELECT * FROM medicament";
            List<Produit> resultat = new List<Produit>();
            // récupération des données de la requête

            SqlDataReader dr = p.execSql(req);

            // passage des données dans le vecteur

            while (dr.Read())
            {
                Produit r = new Produit(dr.GetInt32(1),
                    dr.GetString(3));
                resultat.Add(r);
            }
            p.CloseConnection();
            return resultat;
        }
        public List<Produit> recupererLesProduits()
        {
            
            List<Produit> tousLesProduits = new List<Produit>();

            daoFactory monDaoFactory1 = new daoFactory();
            monDaoFactory1.OuvrirConnexion();

            SqlCommand sqlCommandMedic = new SqlCommand("Select * from dbo.medicament;", monDaoFactory1.connexionBDD);
            SqlDataReader recupProduitsDR = sqlCommandMedic.ExecuteReader();
            if (recupProduitsDR.HasRows) 
            {
                while (recupProduitsDR.Read())
                {
                    unNum = recupProduitsDR.GetInt32(0);
                    unNom = recupProduitsDR.GetString(2);
                    desEffets = recupProduitsDR.GetString(3);
                    unPrixHT = recupProduitsDR.GetDecimal(6);
                }
                recupProduitsDR.Close();

                SqlCommand sqlCommandIncomp = new SqlCommand("Select * from dbo.incompatible;", monDaoFactory1.connexionBDD);
                SqlDataReader recupProduitDR2 = sqlCommandIncomp.ExecuteReader();
                if (recupProduitDR2.HasRows)
                {
                    while (recupProduitDR2.Read())
                    {
                        desIncompatibilites = recupProduitDR2.GetString(0);
                    }
                    recupProduitDR2.Close();

                    SqlCommand sqlCommandInter = new SqlCommand("Select * from dbo.interaction;", monDaoFactory1.connexionBDD);
                    SqlDataReader recupProduitsDR3 = sqlCommandInter.ExecuteReader();
                    if (recupProduitsDR3.HasRows)
                    {
                        while (recupProduitsDR3.Read())
                        {
                            desInteractions = recupProduitsDR3.GetString(0);
                        }
                        recupProduitsDR3.Close();
                    }
                    else
                    {
                        MessageBox.Show("Aucune intéraction trouvées");
                    }
                }
                else
                {
                    MessageBox.Show("Aucune contre_indications trouvées");
                }
            }
            else
            {
                MessageBox.Show("Aucune produits trouvés");
            }

            monDaoFactory1.CloseConnection();

            Produit unProduit = new Produit(unNum, unNom, desEffets, desIncompatibilites, desInteractions, unPrixHT);
            tousLesProduits.Add(unProduit);
            return tousLesProduits;
        }

        public void modifierProduit(int unId, String unNum, String unNom, String desEffets, String desIncompatibilites,
                                        String desInteractions, decimal unPrixHT)
        {
            String requete = "UPDATE produit SET (num =" + unNum +
                                                 ", nom =" + unNom +
                                                 ", effets = " + desEffets +
                                                 ", indications = " + desIncompatibilites +
                                                 ", interactions = " + desInteractions +
                                                 ", prixHT = " + unPrixHT +
                                                 ") where id = " + unId + ";";
        }

        public void ajouterProduit(String unNom, String unNum, String desEffets, String desIncompatibilites, String desInteractions,
                                        decimal unPrixHT)
        {
            String requete = "INSERT INTO produit(num, nom, effets, indications, interactions, prixHT) VALUES(num = " + unNum +
                                                 ", nom = " + unNom +
                                                 ", effets = " + desEffets +
                                                 ", indications = " + desIncompatibilites +
                                                 ", interaction = " + desInteractions +
                                                 ", prixHT = " + unPrixHT +
                                                 ");";
        }

        public static void supprimerProduit(int unId)
        {
            String requete = "DELETE FROM produit WHERE id = " + unId + ";";
        }
    }
}
