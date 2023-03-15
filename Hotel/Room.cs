using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel {
    public class Room {
        public int number { get; set; }
        public int numBed { get; set; }
        public bool hasKitchen{ get; set; }
        public bool hasBalcony { get; set; }
        public bool hasTerrace { get; set; }
        public decimal nightPrice { get; set; }
        public bool available { get; set; }

    }
}
