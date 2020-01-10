using personnageBraux.Persos;

namespace personnageBraux.Interfaces
{
    internal interface IAttaquantArme
    {
        void attaqueSpecialeArme(Personnage p);
        string getArme();
        int getVie();
    }
}