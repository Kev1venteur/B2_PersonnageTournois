using personnageBraux.Persos;

namespace personnageBraux.Interfaces
{
    internal interface IAttaquantMagie
    {
        void attaqueSpecialeMagie(Personnage p);
        string getSort();
        int getVie();
    }
}