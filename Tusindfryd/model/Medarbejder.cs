using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd.model
{
    public class Medarbejder
    {
        private string initialer;
        private string navn;

        public string Initialer { get { return initialer; } set { initialer = value; } }
        public string Navn { get { return navn; } set { navn = value; } }

        public Medarbejder(string initialer, string navn) {
            this.Navn = navn;
            this.Initialer = initialer;
        }
    }
}
