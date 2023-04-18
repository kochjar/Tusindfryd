using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd.model
{
    public class Optælling
    {
        private string id;
        private DateTime optaltDato;
        private int optaltAntal;
        private int beregnetSlutAntal;
        private double afvigelseIProcent;
        private Medarbejder medarbejder;

        public string Id { get { return id; } set { id = value; } }
        public DateTime OptaltDato { get { return optaltDato; } set { optaltDato = value; } }
        public int OptaltAntal { get { return optaltAntal; } set { optaltAntal = value; } }
        public int BeregnetSlutAntal { get { return beregnetSlutAntal; } set { beregnetSlutAntal = value; } }

        public Optælling(string id, DateTime optaltDato, int optaltAntal, int beregnetSlutAntal, double afvigelseIProcent, Medarbejder medarbejder)
        {
            this.Id = id;
            this.OptaltDato = optaltDato;
            this.OptaltAntal = optaltAntal;
            this.BeregnetSlutAntal = beregnetSlutAntal;
            this.afvigelseIProcent = afvigelseIProcent;
            this.medarbejder = medarbejder;
        }
    }
}
