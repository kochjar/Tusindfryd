using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd.model
{
    public class Drivhus
    {
        private string id;
        private List<Produktionsbakke> produktionsbakker;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Produktionsbakke> Produktionsbakker
        {
            get { return produktionsbakker; }
            set { produktionsbakker = value; }
        }

        public Drivhus(string id)
        {
            this.Id = id;
        }

        public void TilføjProduktionsbakke(Produktionsbakke produktionsbakke)
        {
            Produktionsbakker.Add(produktionsbakke);
        }
    }
}
