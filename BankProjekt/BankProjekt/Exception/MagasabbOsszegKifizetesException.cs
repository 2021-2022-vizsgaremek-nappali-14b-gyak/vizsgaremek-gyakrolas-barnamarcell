using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt.Kivetel
{
    public class MagasabbOsszegKifizetesException : Exception
    {
        public MagasabbOsszegKifizetesException(string message) : base(message)
        {
            Debug.WriteLine(message);
        }
    }
}
