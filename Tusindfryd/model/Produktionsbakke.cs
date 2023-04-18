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
        private int startAntal;
        private int forventetSlutAntal;
        private bool afsluttet;

        public string Navn { get { return navn; } set { navn = value; } }
        public int Størrelse { get { return størrelse; } set { størrelse = value; } }
        public BlomsterSort Sort { get { return sort; } set { sort = value; } }
        public Optælling Optælling { get { return optælling; } set { optælling = value; } }
        public DateTime Startdato { get { return startdato; } set { startdato = value; } }
        public int StartAntal { get { return startAntal; } set { startAntal = value; } }
        public int ForventetSlutAntal { get { return forventetSlutAntal; } set { forventetSlutAntal = value; } }
        public bool Afsluttet { get { return afsluttet; } set { afsluttet = value; } }

        public Produktionsbakke(string navn, int størrelse, DateTime startdato, int startAntal, int forventetSlutAntal, bool afsluttet)
        {
            this.Navn = navn;
            this.Størrelse = størrelse;
            this.Startdato = startdato;
            this.StartAntal = startAntal;
            this.ForventetSlutAntal = forventetSlutAntal;
            this.Afsluttet = afsluttet;
        }

        public void TilføjSort(BlomsterSort sort)
        {
            this.Sort = sort;
        }

        public void TilføjOptælling(Optælling sort)
        {
            this.Optælling = optælling;
        }
    }
}
