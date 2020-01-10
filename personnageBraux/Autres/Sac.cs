using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace personnageBraux.Autres
{
    public class Sac
    {
        private static int nombreObjetMaxParSac = 5;
        private int nombreObjetDansSac;
        private Stack sac;
        public Sac()
        {
            this.sac = new Stack();
        }
        public void enleverObjet()
        {
            sac.Pop();
            this.nombreObjetDansSac = sac.Count;
        }
        public void ajouterObjet<T>(T element) // Je créer une classe générique pour pouvoir mettre ce que je veux dans mon sac
        {
            if (nombreObjetDansSac < nombreObjetMaxParSac)
            {
                sac.Push(element);
                this.nombreObjetDansSac = sac.Count;
            }
            else
            {
                Console.WriteLine("\nSac déja plein!");
            }
        }
        public int getNombreObjetDansSac()
        {
            return this.nombreObjetDansSac;
        }
        public int getNombreObjetMaxSac()
        {
            return nombreObjetMaxParSac;
        }
    }
}
