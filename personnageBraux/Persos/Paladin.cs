using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux
{
    class Paladin : Personnage, IAttaquantArme, IAttaquantMagie
    {
        private Arme armePortee;
        private Sort sortAcquis;

        private static int vieMax = 20;
        private static int maxForce = 15;
        private static int maxAgilite = 15;
        public Paladin(string name)
            : base(name)
        {
            this.setVie(20);
            this.nbSacMax = 2;
            this.rempirStackSac();
            this.sortAcquis = new Sort();
            this.armePortee = new Arme();
        }
        public void attaqueSpecialeMagie(Personnage persoADemonter)
        {
            persoADemonter.setVie(persoADemonter.getVie() - sortAcquis.getPuissance());
        }
        public string getSort()
        {
            return "Type: " + sortAcquis.getNom() + ", Puissance: " + sortAcquis.getPuissance();
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
