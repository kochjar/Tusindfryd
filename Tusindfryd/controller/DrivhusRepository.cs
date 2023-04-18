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

        private MedarbejderRepository medarbejderRepo;

        public DrivhusRepository(MedarbejderRepository medarbejderRepository) { 
            this.drivhuse = new List<Drivhus>();
            this.medarbejderRepo = medarbejderRepository;
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

        public void TilføjProduktionsbakke(string drivhusId, string navn, int størrelse, 
        DateTime startdato, int startAntal, int forventetSlutAntal, bool afsluttet)
        {
            foreach (Drivhus drivhus in drivhuse)
            {
                if(drivhus.Id == drivhusId)
                {
                    drivhus.TilføjProduktionsbakke(new Produktionsbakke(navn, størrelse, startdato, startAntal, forventetSlutAntal, afsluttet));
                }
            }
        }

        public void TilføjSort(string navn, int produktionsTidIDage, TimeSpan halveringstid, string produktionsbakkeNavn) { 
            foreach (Drivhus drivhus in drivhuse)
            {
                foreach(Produktionsbakke produktionsbakke in drivhus.Produktionsbakker)
                {
                    if (produktionsbakkeNavn == produktionsbakke.Navn)
                    {
                        produktionsbakke.TilføjSort(new BlomsterSort(navn, produktionsTidIDage, halveringstid));
                    }
                }
            }
        }

        public void TilføjOptælling(string produktionsbakkeNavn, string id, DateTime optaltDato,int optaltAntal, int beregnetSlutAntal,
            double afvigelseIProcent, string medarbejderInitialer) {

            foreach (Drivhus drivhus in drivhuse)
            {
                foreach (Produktionsbakke produktionsbakke in drivhus.Produktionsbakker)
                {
                    if (produktionsbakkeNavn == produktionsbakke.Navn)
                    {
                        produktionsbakke.TilføjOptælling(new Optælling(id, optaltDato, optaltAntal, beregnetSlutAntal, afvigelseIProcent));

                        Medarbejder fundetMedarbejder = this.medarbejderRepo.HentMedarbejder(medarbejderInitialer);

                        produktionsbakke.Optælling.TilføjMedarbejder(fundetMedarbejder);
                    }
                }
            }
        }


    }
}
