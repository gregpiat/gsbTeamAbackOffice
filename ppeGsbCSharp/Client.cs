using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ppeGsbCSharp
{
    class Client
    {
        private int id;
        private String nom;
        private String prenom;
        private String raisonSociale;
        private String ville;
        private String adresse;
        private String cp;
        private String email;
        //private String tel;
        private int idTypeProfessionnel;


        private ArrayList lesVisites;




        public Client(int unId, String unNom, String unPrenom, String uneRaisonSociale, String uneVille, String uneAdresse, 
                                                                    String unCp, String unEmail, int unIdTypeProfessionnel)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            raisonSociale = uneRaisonSociale;
            ville = uneVille;
            adresse = uneAdresse;
            cp = unCp;
            email = unEmail;
            //tel = unTel;
            idTypeProfessionnel = unIdTypeProfessionnel;
            lesVisites = new ArrayList();
        }

        public void ajouterVisite(Visite uneVisite){
            lesVisites.Add(uneVisite);
        }


        #region Getters et setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public String RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value; }
        }

        public String Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public String Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public int IdTypeProfessionnel
        {
            get { return idTypeProfessionnel; }
            set { idTypeProfessionnel = value; }
        }

        public ArrayList LesVisites
        {
            get { return LesVisites; }
            set { LesVisites = value; }
        }
        #endregion
    }
}
