using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ppeGsbCSharp
{
    class Client
    {
        private String nom;
        private String code;
        private String raison;
        private String adresse;
        private String type;
        private String tel;
        private String mail;
        private DateTime date;
        private ArrayList lesRdv;


        public Client(String unNom, String unCode, String uneRaison, String uneAdresse, String unType, String unTel, String unMail, DateTime uneDate)
        {
            nom = unNom;
            code = unCode;
            raison = uneRaison;
            adresse = uneAdresse;
            type = unType;
            tel = unTel;
            mail = unMail;
            date = uneDate;
            lesRdv = new ArrayList();
        }


        #region Getters et setters
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        public String Raison
        {
            get { return raison; }
            set { raison = value; }
        }
        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public String Type
        {
            get { return type; }
            set { type = value; }
        }
        public String Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public ArrayList LesRdv
        {
            get { return lesRdv; }
            set { lesRdv = value; }
        }
        #endregion



    }
}
