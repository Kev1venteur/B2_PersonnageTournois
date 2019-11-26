using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux
{
    class Arme
    {
        private string type;
        private int puissance;

        public Arme()
        {
            this.type = "hache";
            this.puissance = 20;
        }
        public string getType()
        {
            return this.type;
        }
        public int getPuissance()
        {
            return this.puissance;
        }
    }
}
