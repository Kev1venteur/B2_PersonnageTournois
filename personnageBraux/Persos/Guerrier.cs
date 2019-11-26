using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace personnageBraux
{
    class Guerrier : Personnage, IAttaquantArme
    {
        private static int vieMax = 30;
        private static int maxForce = 20;
        private static int maxAgilite = 15;
        private Arme armePortee;
        public Guerrier(string name)
            : base(name)
        {
            this.setVie(30);
            this.nbSacMax = 5;
            this.rempirStackSac();
            this.armePortee = new Arme();
        }
        public void attaqueSpecialeArme(Personnage persoADemonter)
        {
            persoADemonter.setVie(persoADemonter.getVie() - armePortee.getPuissance());
        }
        public string getArme()
        {
            return "Type: " + armePortee.getType() + ", Puissance: " + armePortee.getPuissance();
        }
    }
}
