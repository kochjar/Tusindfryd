using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd.model
{
    public class Drivhus
    {
        private int nummer;
        private List<Produktionsbakke> produktionsbakker;

        public int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }

        public List<Produktionsbakke> Produktionsbakker
        {
            get { return produktionsbakker; }
            set { produktionsbakker = value; }
        }

        public Drivhus(int nummer)
        {
            this.nummer = nummer;
        }

        public void TilføjProduktionsbakke(Produktionsbakke produktionsbakke)
        {
            Produktionsbakker.Add(produktionsbakke);
        }
    }
}
