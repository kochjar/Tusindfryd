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
    }

}
