using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tusindfryd.controller;
using Tusindfryd.model;

namespace Tusindfryd.controller
{
    public class Controller
    {
        private DrivhusRepository drivhusRepository;
        private MedarbejderRepository medarbejderRepository;

        public Controller() { 
            this.medarbejderRepository = new MedarbejderRepository();
            this.drivhusRepository = new DrivhusRepository(medarbejderRepository);
        }
        
        public void TilføjDrivhus(string id) { drivhusRepository.TilføjDrivhus(id); }

        public void SletDrivhus(string id) { drivhusRepository.SletDrivhus(id); }

        public void TilføjProduktionsbakke(string drivhusId, string navn, int størrelse,
        DateTime startdato, int startAntal, int forventetSlutAntal, bool afsluttet)
        { drivhusRepository.TilføjProduktionsbakke(drivhusId, navn, størrelse, startdato, startAntal, forventetSlutAntal, afsluttet); }

        public void SletProduktionsbakke(string drivhusId, string produktionsbakkeNavn)
        {
            drivhusRepository.SletProduktionsbakke(drivhusId, produktionsbakkeNavn);
        }

        public void TilføjSort(string navn, int produktionsTidIDage, TimeSpan halveringstid, string produktionsbakkeNavn)
        { drivhusRepository.TilføjSort(navn, produktionsTidIDage, halveringstid, produktionsbakkeNavn); }

        public void TilføjOptælling(string produktionsbakkeNavn, string id, DateTime optaltDato, int optaltAntal, int beregnetSlutAntal,
        double afvigelseIProcent, string medarbejderInitialer)
        {
            drivhusRepository.TilføjOptælling(produktionsbakkeNavn, id, optaltDato, optaltAntal,
                                              beregnetSlutAntal, afvigelseIProcent, medarbejderInitialer);
        }

        public void TilføjMedarbejder(string initialer, string navn)
        {
            medarbejderRepository.TilføjMedarbejder(initialer, navn);
        }

        public void SletMedarbjeder(string initialer)
        {
            medarbejderRepository.SletMedarbjeder(initialer);
        }

        public List<Medarbejder> HentAlleMedarbejdere()
        {
            return medarbejderRepository.HentAlle();
        }
        public void HentMedarbejder(string initialer)
        {
            medarbejderRepository.HentMedarbejder(initialer);
        }

        public List<Drivhus> HentAlleDrivhuse()
        {
            return drivhusRepository.HentAlle();
        }

    }
}
