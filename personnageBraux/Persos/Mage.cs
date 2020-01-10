using personnageBraux.Interfaces;
using personnageBraux.Autres;

namespace personnageBraux.Persos
{
    class Mage : Personnage, IAttaquantMagie
    {
        private static int vieMax = 15;
        private int mana = 20;
        private static int manaMax = 20;
        private static int maxForce = 15;
        private static int maxAgilite = 15;
        private Sort sortAcquis;
        public Mage(string name)
            : base(name)
        {
            this.setVie(15);
            this.nbSacMax = 2;
            this.rempirStackSac();
            this.sortAcquis = new Sort();
        }
        public void attaqueSpecialeMagie(Personnage persoADemonter)
        {
            persoADemonter.setVie(persoADemonter.getVie() - sortAcquis.getPuissance());
        }
        public string getSort()
        {
            return "Type: " + sortAcquis.getNom() + ", Puissance: " + sortAcquis.getPuissance();
        }
    }
}
