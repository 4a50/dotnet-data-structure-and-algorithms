using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
    class Dog : Animal
    {
        public override string Species { get; set; } = "Dog";
        public override Animal Next { get; set; }
        public override int UniqueID { get; set; }        

        public Dog()
        {           
            Queue = new Queue<Animal>();
        }
    }
}
