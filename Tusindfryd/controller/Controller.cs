using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
