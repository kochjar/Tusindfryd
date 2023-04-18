using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd.model
{
    public class BlomsterSort
    {
        private string navn;
        private int produktionsTidIDage;
        private TimeSpan halveringstid;

        public string Navn { get { return navn; } set { navn = value; } }
        public int ProduktionsTidIDage { get { return produktionsTidIDage;} set { produktionsTidIDage = value; } }
        public TimeSpan Halveringstid { get { return halveringstid; } set { halveringstid = value; } }

        public BlomsterSort(string navn, int produktionsTidIDage, TimeSpan halveringstid) { 
            this.Navn = navn;
            this.ProduktionsTidIDage = produktionsTidIDage;
            this.Halveringstid = halveringstid;
        }
    }
}
