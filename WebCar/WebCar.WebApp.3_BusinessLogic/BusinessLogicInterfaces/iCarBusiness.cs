using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;
using WebCar.Common.Models;

namespace WebCar.WebApp._3_BusinessLogic.BusinessLogicInterfaces
{
    public interface iCarBusiness 
    {
        Task<List<CarTypes>> SearchCarAsync(CarSearchingParameters CarSearchingParameters);
    }
}
