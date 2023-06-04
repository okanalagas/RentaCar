using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Entities.Models
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public string PickUpOffice { get; set; }
        public string DropOffOffice { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public decimal TotalRental { get; set; }

        //Relational Properties     
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
