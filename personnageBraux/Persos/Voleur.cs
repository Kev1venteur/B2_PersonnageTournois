using personnageBraux.Interfaces;
using personnageBraux.Autres;

namespace personnageBraux.Persos
{
    class Voleur : Personnage, IAttaquantArme
    {
        private static int vieMax = 20;
        private static int maxForce = 15;
        private static int maxAgilite = 20;
        private Arme armePortee;
        public Voleur(string name)
            : base(name)
        {
            this.setVie(20);
            this.nbSacMax = 3;
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
