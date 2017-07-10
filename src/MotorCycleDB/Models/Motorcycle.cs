using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotorCycleDB.Models
{
    public class Motorcycle
    {
        public string ModelId { get; set; }
        public int ModelYear { get; set; }

        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Mfg Mfg { get; set; }

    }
}