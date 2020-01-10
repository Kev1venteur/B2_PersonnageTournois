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
        public sacPushException(int error_number)
        {
            if(error_number == 1)
            {
                Console.WriteLine("Problème lors de l'ajout d'un objet");
            }
            else if (error_number == 2)
            {
                Console.WriteLine("Problème lors de l'ajout de plus d'objet que le max prévu");
            }
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
