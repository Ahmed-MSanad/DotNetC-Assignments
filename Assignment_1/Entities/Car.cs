using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Entities
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override string ToString() => $"Id: {Id}, Maker: {Make}, Model: {Model}, NumberOfDoors: {NumberOfDoors}";
    }
}
