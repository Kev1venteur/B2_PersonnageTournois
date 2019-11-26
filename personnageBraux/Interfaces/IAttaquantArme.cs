namespace personnageBraux
{
    internal interface IAttaquantArme
    {
        void attaqueSpecialeArme(Personnage p);
        string getArme();
        int getVie();
    }
}