using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux
{
    class Team
    {
        public SortedSet<Personnage> team;
        public int numberOfPerso;
        public Team()
        {
            this.team = new SortedSet<Personnage>();
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                int typePerso = rand.Next(1, 6); //nombre aléatoire entre 1 et 5

                string name = i.ToString();

                if (typePerso == 1)
                {
                    this.team.Add(new Guerrier("TeamMember_" + name));
                }
                else if (typePerso == 2)
                {
                    this.team.Add(new Chaman("TeamMember_" + name));
                }
                else if (typePerso == 3)
                {
                    this.team.Add(new Voleur("TeamMember_" + name));
                }
                else if (typePerso == 4)
                {
                    this.team.Add(new Mage("TeamMember_" + name));
                }
                else if (typePerso == 5)
                {
                    this.team.Add(new Paladin("TeamMember_" + name));
                }
            }
            this.numberOfPerso = 10;
            Console.WriteLine("\nEquipe de " + 10 + " joueurs créée! \nVoici sa composotion :\n");
        }
        public Team(int nbJoueurs)
        {
            this.team = new SortedSet<Personnage>();
            for (int i = 0; i < nbJoueurs; i++)
            {
                Random rand = new Random();
                int typePerso = rand.Next(1, 6);

                string name = i.ToString();

                if (typePerso == 1)
                {
                    this.team.Add(new Guerrier("TeamMember_" + name));
                }
                else if (typePerso == 2)
                {
                    this.team.Add(new Chaman("TeamMember_" + name));
                }
                else if (typePerso == 3)
                {
                    this.team.Add(new Voleur("TeamMember_" + name));
                }
                else if (typePerso == 4)
                {
                    this.team.Add(new Mage("TeamMember_" + name));
                }
                else if (typePerso == 5)
                {
                    this.team.Add(new Paladin("TeamMember_" + name));
                }
            }
            this.numberOfPerso = nbJoueurs;
            Console.WriteLine("\nEquipe de " + nbJoueurs + " joueurs créée! \nVoici sa composotion :\n");
        }
        public void afficher()
        {
            foreach (Personnage Perso in team) // ... Alphabetical order.
            {
                Console.WriteLine("Nom: " + Perso.getName() + ", Type: " + Perso.GetType() + ", Vie: " + Perso.getVie() + "\n");
            }
        }
    }
}
