using BankProjekt.Kivetel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjekt.Model
{
   public class Egyenleg
    {
        private int osszeg;

        public Egyenleg(int osszeg)
        {
            this.Osszeg = osszeg;
        }

        public int Osszeg { get => osszeg; set => osszeg = value; }

        public void Befizetes(int osszeg)
        {
            if (osszeg < 0)
                throw new NegativOsszegBefizeteseException(osszeg + " Ft-t nem lehet befizetni!");
            this.osszeg = this.osszeg + osszeg;
            
        }

        public void Kifizetes(int osszeg)
        {
            if (osszeg <= 0)
                throw new MagasabbOsszegKifizetesException(osszeg + " Ft-t összeget nem lehet kivenni!");
           this.osszeg = this.osszeg - osszeg;

        }
    }
}
