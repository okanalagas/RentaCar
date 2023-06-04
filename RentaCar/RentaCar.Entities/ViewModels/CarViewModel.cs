using RentaCar.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Entities.ViewModels
{
    public class CarViewModel
    {
        public CarViewModel()
        {
                Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
    }
}
