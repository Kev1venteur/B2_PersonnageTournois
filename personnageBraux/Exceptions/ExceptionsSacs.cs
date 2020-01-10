using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux.Exceptions
{
    public class sacCreationException : Exception
    {
        public sacCreationException()
        {
            Console.WriteLine("Impossible de créer un sac");
        }
    }
    public class sacPushException : Exception
    {
        public sacPushException()
        {
            Console.WriteLine("Impossible d'ajouter un objet au sac");
        }
    }
    public class sacPopException : Exception
    {
        public sacPopException()
        {
            Console.WriteLine("Impossible d'ejecter un objet du sac");
        }
    }
    public class sacComptageException : Exception
    {
        public sacComptageException()
        {
            Console.WriteLine("Impossible de compter les objets dans le sac");
        }
    }
}
