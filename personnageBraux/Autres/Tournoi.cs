using personnageBraux.Exceptions;
using personnageBraux.Interfaces;
using personnageBraux.Persos;
using System;

namespace personnageBraux.Autres
{
    class Tournoi
    {
        public void accepterTournoi(IAttaquantArme un, IAttaquantArme deux)
        {
            int turn = 1;
            while (un.getVie() > 0 && deux.getVie() > 0)
            {
                if (turn == 1)
                {
                    Personnage cible = deux as Personnage;
                    un.attaqueSpecialeArme(cible);
                    turn++;
                }
                else if (turn == 2)
                {
                    Personnage cible = un as Personnage;
                    deux.attaqueSpecialeArme(cible);
                    turn--;
                }
                try
                {
                    if (un.getVie() <= 0 || deux.getVie() <= 0)
                    {
                        throw new pdvSousZeroException();
                    }
                }
                catch (pdvSousZeroException)
                {
                    Console.WriteLine("Impossible de se battre, un des deux combattants est mort !!!");
                }
            }
        }
        public void accepterTournoi(IAttaquantMagie un, IAttaquantMagie deux)
        {
            int turn = 1;
            while (un.getVie() > 0 && deux.getVie() > 0)
            {
                if (turn == 1)
                {
                    Personnage cible = deux as Personnage;
                    un.attaqueSpecialeMagie(cible);
                    turn++;
                }
                else if (turn == 2)
                {
                    Personnage cible = un as Personnage;
                    deux.attaqueSpecialeMagie(cible);
                    turn--;
                }
                try
                {
                    if (un.getVie() <= 0 || deux.getVie() <= 0)
                    {
                        throw new pdvSousZeroException();
                    }
                }
                catch (pdvSousZeroException){}
            }
        }
    }
}
