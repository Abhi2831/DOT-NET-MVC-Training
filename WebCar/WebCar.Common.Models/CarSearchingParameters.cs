using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;

namespace WebCar.Common.Models
{
    public class CarSearchingParameters
    {
        public string? CarName { get; set; }
        public string? ReleaseDate { get; set; }
        public CarTypes? ColorOfCar { get; set; }
    }
}
