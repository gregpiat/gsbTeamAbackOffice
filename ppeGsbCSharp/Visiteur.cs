using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeGsbCSharp
{
    class Visiteur
    {
        private int id;
        private String nom;
        private String prenom;

        public Visiteur(int unId, String unNom, String unPrenom)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
        }
    }
}
