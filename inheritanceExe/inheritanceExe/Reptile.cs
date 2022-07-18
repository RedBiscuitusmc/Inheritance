using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {


        }

        public bool hasScales { get; set; }
        public int runSpeed { get; set; }
        public string reptileName { get; set; }
        public bool hasPoison { get; set; }

    }
}
