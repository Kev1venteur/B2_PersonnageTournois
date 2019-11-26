namespace personnageBraux
{
    internal interface IAttaquantMagie
    {
        void attaqueSpecialeMagie(Personnage p);
        string getSort();
        int getVie();
    }
}