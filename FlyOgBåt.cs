using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    abstract class FlyOgBåt
    {
        public string RegNr { get; protected set; }
        public int Effekt { get; set; }

        protected FlyOgBåt(string regNr, int effekt)
        {
            RegNr = regNr;
            Effekt = effekt;
        }
        public virtual string PrintInfo()
        {
            return ($"Regnr : {RegNr}\n" +
                    $"Effekt: {Effekt}kw\n");
        }

        public virtual string Run()
        {
            return ("");
        }
    }
}
