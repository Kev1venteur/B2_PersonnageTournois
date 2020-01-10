using personnageBraux.Autres;
using personnageBraux.Interfaces;
using personnageBraux.Persos;
using System;

namespace personnageBraux
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage joueur1 = null;
            //Récupération du nom
            Console.WriteLine("Bonjour, quel est ton nom?");
            string name = Console.ReadLine();

            //Boucle de vérification du type du perso
            bool typePersoValide = false;
            while (!typePersoValide)
            {
                Console.Clear();

                //Récupération du type du personnage
                Console.WriteLine("Quel sera ton type de personnage?");
                Console.WriteLine("1 : Guerrier");
                Console.WriteLine("2 : Voleur");
                Console.WriteLine("3 : Mage");
                Console.WriteLine("4 : Chaman");
                Console.WriteLine("5 : Paladin");
                string getTypePerso = Console.ReadLine();
                int typePerso = int.Parse(getTypePerso);

                //Création du personnage en fonction du type en précisant le nom
                if (typePerso == 1)
                {
                    typePersoValide = true;
                    joueur1 = new Guerrier(name);
                    Console.WriteLine("Votre Guerrier a été créé !");
                }
                else if (typePerso == 2)
                {
                    typePersoValide = true;
                    joueur1 = new Voleur(name);
                    Console.WriteLine("Votre Voleur a été créé !");
                }
                else if (typePerso == 3)
                {
                    typePersoValide = true;
                    joueur1 = new Mage(name);
                    Console.WriteLine("Votre Mage a été créé !");
                }
                else if (typePerso == 4)
                {
                    typePersoValide = true;
                    joueur1 = new Chaman(name);
                    Console.WriteLine("Votre Chaman a été créé !");
                }
                else if (typePerso == 5)
                {
                    typePersoValide = true;
                    joueur1 = new Paladin(name);
                    Console.WriteLine("Votre Paladin a été créé !");
                }
                else
                {
                    Console.WriteLine("Valeur saisie incorrecte ! Veuillez saisir une valeur entre 1 et 4");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            Team equipe1 = new Team(); //Créer une team de 10 perso aléatoire (Par défaut)
            equipe1.afficher();
            Tournoi tournoi = new Tournoi();
            IAttaquantMagie joueur2 = new Mage("j2");
            IAttaquantArme joueur3 = new Guerrier("j3");

            //tournoi.accepterTournoi(joueur1, joueur2); //besoin de caster les type pour lancer un tournoi
            Console.WriteLine(joueur1.getVie());
            Console.WriteLine(joueur2.getVie());
        }
    }
}