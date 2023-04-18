using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tusindfryd.model;

namespace Tusindfryd.controller
{
    public class MedarbejderRepository
    {
        private List<Medarbejder> medarbejdere;

        public MedarbejderRepository()
        {
            this.medarbejdere = new List<Medarbejder>();
        }

        public void TilføjMedarbejder(string initialer, string navn)
        {
            medarbejdere.Add(new Medarbejder(initialer, navn));
        }

        public void SletMedarbjeder(string initialer)
        {
            foreach (Medarbejder medarbejder in medarbejdere)
            {
                if(medarbejder.Initialer == initialer)
                {
                    medarbejdere.Remove(medarbejder);
                }
            }
        }

        public List<Medarbejder> HentAlle()
        {
            return medarbejdere;
        }

        public Medarbejder HentMedarbejder(string initialer)
        {
            foreach (Medarbejder medarbejder in medarbejdere)
            {
                if (initialer == medarbejder.Initialer)
                {
                    return medarbejder;
                }
            }
            return null;
        }
                /*
        public void TilføjMedarbejderTilOptælling(string initialer, Optælling optælling)
        {
            foreach(Medarbejder medarbejder in medarbejdere)
            {
                if (initialer == medarbejder.Initialer)
                {
                    optælling.Medarbejder = medarbejder;
                }
            }
        }*/
    }

}
