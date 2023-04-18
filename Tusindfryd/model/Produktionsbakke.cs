using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd.model
{
    public class Produktionsbakke
    {
        private string navn;
        private int størrelse;
        private Optælling optælling;
        private BlomsterSort sort;
        private DateTime startdato;
        private DateTime slutdato;
        private int startAntal;
        private int forventetSlutAntal;
        private bool afsluttet;

        public string Navn { get { return navn; } set { navn = value; } }
        public int Størrelse { get { return størrelse; } set { størrelse = value; } }
        public Optælling Optælling { get { return optælling; } set { optælling = value; } }
        public DateTime Startdato { get { return startdato; } set { startdato = value; } }
        public DateTime Slutdato { get { return slutdato; } set { slutdato = value; } }
        public int StartAntal { get { return startAntal; } set { startAntal = value; } }
        public int ForventetSlutAntal { get { return forventetSlutAntal; } set { forventetSlutAntal = value; } }
        public bool Afsluttet { get { return afsluttet; } set { afsluttet = value; } }

        public Produktionsbakke(string navn, int størrelse, Optælling optælling, BlomsterSort sort, DateTime startdato,
        DateTime slutdato, int startAntal, int forventetSlutAntal, bool afsluttet)
        {
            Navn = navn;
            Størrelse = størrelse;
            Optælling = optælling;
            this.sort = sort;
            Startdato = startdato;
            Slutdato = slutdato;
            StartAntal = startAntal;
            ForventetSlutAntal = forventetSlutAntal;
            Afsluttet = afsluttet;
        }
    }
}
