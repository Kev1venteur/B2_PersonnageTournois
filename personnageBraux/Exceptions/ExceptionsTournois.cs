using System;
using System.Collections.Generic;
using System.Text;

namespace personnageBraux.Exceptions
{
    class pdvSousZeroException : Exception
    {
        public pdvSousZeroException()
        {
            Console.WriteLine("Impossible de continuer de se battre, un des deux combattants n'a plus de point de vie !!!");
        }
    }
}
