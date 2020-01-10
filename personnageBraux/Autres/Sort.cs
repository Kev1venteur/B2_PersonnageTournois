using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux.Autres
{
    class Sort
    {
        private string nom;
        private int puissance;

        public Sort()
        {
            this.nom = "brule_en_enfer";
            this.puissance = 20;
        }
        public string getNom()
        {
            return this.nom;
        }
        public int getPuissance()
        {
            return this.puissance;
        }
    }
}
