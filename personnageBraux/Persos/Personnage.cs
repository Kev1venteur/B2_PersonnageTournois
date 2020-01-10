using personnageBraux.Autres;
using System;
using System.Collections.Generic;

namespace personnageBraux.Persos
{
    abstract class Personnage : IComparable<Personnage>
    {
        private string nom;
        private int force;
        private int agilite;
        private int vie;
        protected int nbSacMax;
        protected Stack<Sac> stackSac;

        public Personnage(string name)
        {
            this.nom = name;
        }
        public Personnage()
        {
        }

        public int getVie()
        {
            return this.vie;
        }

        public void setVie(int life)
        {
            this.vie = life;
        }

        public string getName()
        {
            return this.nom;
        }

        protected void viderSacNumero(int numeroSac)
        {
            this.stackSac.ToArray()[numeroSac].enleverObjet();
        }

        protected void remplirSacNumero(int numeroSac, string objetAAjouter)
        {
            this.stackSac.ToArray()[numeroSac].ajouterObjet(objetAAjouter);
        }

        protected void rempirStackSac()
        {
            this.stackSac = new Stack<Sac>();
            for (int i = 0; i < this.nbSacMax; i++)
            {
                this.stackSac.Push(new Sac());
            }
        }

        public int CompareTo(Personnage p)
        {
            int result = string.Compare(this.getName(), p.getName());
            return result;
        }
    }
}
