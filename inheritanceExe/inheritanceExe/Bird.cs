using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public string Bird_Name { get; set; }
        public string Color { get; set; }
        public int WingSpan { get; set; }
        public bool CanLayEggs { get; set; }
    }
}
