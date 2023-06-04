using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Entities.Models
{
    public class Car : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
        public string TransmissionType { get; set; }
        public string FuelType { get; set; }
        public int Km { get; set; }
        public int Seat { get; set; }
        public bool isRented { get; set; }
        public string Image { get; set; }
        public decimal Rental { get; set; }

        //Relational Properties
        public virtual List<Order> Orders { get; set; }
    }
}
