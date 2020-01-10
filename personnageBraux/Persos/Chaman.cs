using personnageBraux.Interfaces;
using personnageBraux.Autres;

namespace personnageBraux.Persos
{
    class Chaman : Personnage, IAttaquantMagie
    {
        private static int vieMax = 20;
        private static int maxForce = 15;
        private static int maxAgilite = 15;
        private Sort sortAcquis;
        public Chaman(string name)
            : base(name)
        {
            this.setVie(20);
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
