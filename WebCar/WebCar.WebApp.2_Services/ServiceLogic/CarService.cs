using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;
using WebCar.Common.Models;
using WebCar.WebApp._2_Services.ServiceInterfaces;
using WebCar.WebApp._3_BusinessLogic.BusinessLogicInterfaces;

namespace WebCar.WebApp._2_Services.ServiceLogic
{
    public class CarService : ICar
        
    {
        private readonly iCarBusiness icarBusiness
            ;

        public CarService(iCarBusiness _icarBusinessLogic)
        {
            _icarBusinessLogic = _icarBusinessLogic;
        }

    
        public async Task<List<CarModel>> SearchCarAsync(CarSearchingParameters carSearchingParameters)
        {
            return await iCarBusiness.SearchCarAsync(carSearchingParameters);
        }
    }
}
