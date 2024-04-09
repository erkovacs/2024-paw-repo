using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST01_2_1071_Kovacs_Erik.Entities
{
    [Serializable]
    internal class Fleet
    {
        public int Id { get; set; }
        public List<Truck> Trucks { get; set; }

        public Fleet() 
        {
            Id = 1;
            Trucks = new List<Truck>();
        }
    }
}
