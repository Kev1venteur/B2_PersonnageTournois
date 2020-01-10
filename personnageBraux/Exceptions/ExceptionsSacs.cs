using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux.Exceptions
{
    public class sacPushNeFonctionnePas : Exception
    {
        public sacPushNeFonctionnePas()
        {
            Console.WriteLine("Impossible d'ajouter un objet au sac");
        }
    }
    public class sacPopNeFonctionnePas : Exception
    {
        public sacPopNeFonctionnePas()
        {
            Console.WriteLine("Impossible d'ejecter un objet du sac");
        }
    }
}
