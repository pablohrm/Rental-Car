using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Aluguel.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(String model)
        {
            Model = model;
        }
    }
}
