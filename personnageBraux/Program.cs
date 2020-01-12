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
            //Team equipe1 = new Team(); //Créer une team de 10 perso aléatoire (Il est aussi possible de spécifier un nombre de membres)
            //equipe1.afficher();

            Tournoi tournoi = new Tournoi();

            IAttaquantMagie joueur2 = new Mage("j2");     //  On Créer des personnages
            IAttaquantArme joueur3 = new Guerrier("j3");  //     pour se battre avec le joueur 1

            //Bloc pour demander au joueur s'il veut jouer avec les armes ou les sort si il est paladin
            int sortOuArme = 0; 
            if (joueur1 is Persos.Paladin)
            {
                Console.WriteLine("En tant que paladin, voulez-vous jouer avec les sort ou les armes?");
                Console.WriteLine("1 : Sort");
                Console.WriteLine("2 : Arme");
                string getTypePerso = Console.ReadLine();
                sortOuArme = int.Parse(getTypePerso);
            }

            //On cast le joueur 1 en fonction de son type de personnage choisi
            if (joueur1 is Persos.Mage || joueur1 is Persos.Chaman || sortOuArme == 1)
            {
                IAttaquantMagie castedJoueur1Magie = (IAttaquantMagie)joueur1;
                Console.WriteLine("\nLes Personnage vont se battre tour à tour automatiquement\n");
                tournoi.accepterTournoi(ref castedJoueur1Magie, ref joueur2);
                Console.WriteLine("\nVie de votre personnage : " + castedJoueur1Magie.getVie());
                Console.WriteLine("Vie du personnage adverse : " + joueur2.getVie());
            }
            else if (joueur1 is Persos.Guerrier || joueur1 is Persos.Voleur || sortOuArme == 2)
            {
                IAttaquantArme castedJoueur1Arme = (IAttaquantArme)joueur1;
                Console.WriteLine("\nLes Personnage vont se battre tour à tour automatiquement\n");
                tournoi.accepterTournoi(ref castedJoueur1Arme, ref joueur3);
                Console.WriteLine("\nVie de votre personnage : " + castedJoueur1Arme.getVie());
                Console.WriteLine("Vie du personnage adverse : " + joueur3.getVie());
            }
        }
    }
}