using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tusindfryd.model;

namespace Tusindfryd.controller
{
    public class DrivhusRepository
    {
        private List<Drivhus> drivhuse;
        public DrivhusRepository() { 
            this.drivhuse = new List<Drivhus>();
        }

        public void TilføjDrivhus(string id)
        {
            drivhuse.Add(new Drivhus(id));
        }

        public void SletDrivhus(string id)
        {
            foreach (Drivhus drivhus in drivhuse)
            {
                if (id == drivhus.Id)
                {
                    drivhuse.Remove(drivhus);
                }
            }
        }

        public void TilføjProduktionsbakke(string drivhus_id, string produktionsbakke_navn, int størrelse, string sort_navn)
        {

        }

        public void TilføjSort(string navn, int produktionsTidIDage, TimeSpan halveringstid, string produktionsbakke_navn, string drivhus_id) { 
            foreach (Drivhus drivhus in drivhuse)
            {
                foreach(Produktionsbakke produktionsbakke in drivhus.Produktionsbakker)
                {
                    if (produktionsbakke_navn == produktionsbakke.Navn)
                    {
                        produktionsbakke.Sort = new BlomsterSort(navn, produktionsTidIDage, halveringstid);
                    }
                }
            }
        }

        public void TilføjOptælling() { }


    }
}
