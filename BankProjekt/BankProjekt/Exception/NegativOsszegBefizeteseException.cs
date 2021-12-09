using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt.Kivetel
{
    public class NegativOsszegBefizeteseException : Exception
    {
        public NegativOsszegBefizeteseException(string message) : base(message)
        {
            Debug.WriteLine(message);
        }
    }
}
