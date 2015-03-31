using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ppeGsbCSharp
{
    public class Produit
    {
        private int num;
        private String nom;
        private String effets;
        private String indications;
        private String interactions;
        private decimal prixHT;
        private decimal dosage;
        public Produit(int unNum, string unNom)
        {
            num = unNum;
            nom = unNom;
        }
        public Produit(int unNum, String unNom, String desEffets, String desIndications, String desInteractions,
                            decimal unPrixHT)
        {
            unNum = num;
            unNom = nom;
            desEffets = effets;
            desIndications = indications;
            desInteractions = interactions;
            unPrixHT = prixHT;
        }

        public int getNum()
        {
            return num;
        }

        public void setNum(int unNum)
        {
            this.num = unNum;
        }

        public String getNom()
        {
            return nom;
        }

        public void setNom(String unNom)
        {
            this.nom = unNom;
        }

        public String getEffets()
        {
            return effets;
        }

        public void setEffets(String desEffets)
        {
            this.effets = desEffets;
        }

        public String getIndications()
        {
            return indications;
        }

        public void setIndications(String desIndications)
        {
            this.indications = desIndications;
        }

        public String getInteractions()
        {
            return interactions;
        }

        public void setInteractions(String desInteractions)
        {
            this.interactions = desInteractions;
        } 

        public decimal getPrixHT()
        {
            return prixHT;
        }

        public void setPrixHT(decimal unPrixHT)
        {
            this.prixHT = unPrixHT;
        }

        public decimal getDosage()
        {
            return dosage;
        }

        public void setDosage(decimal unDosage)
        {
            this.dosage = unDosage;
        }
    }
}
