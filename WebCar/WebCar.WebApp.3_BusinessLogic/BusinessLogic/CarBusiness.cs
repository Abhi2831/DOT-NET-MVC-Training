using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;
using WebCar.Common.Models;
using WebCar.WebApp._3_BusinessLogic.BusinessLogicInterfaces;
using WebCar.WebApp._4_DataAcess.IRepository;

namespace WebCar.WebApp._3_BusinessLogic.BusinessLogic
{
    public class CarBusiness : iCarBusiness
    {

        private readonly ICarRepository iCarRepository;
        private ICarRepository iCarBusiness;

        public CarBusiness (ICarRepository  _iCarRepository)
            {
                iCarBusiness = _iCarRepository;
            }

        public async Task<List<CarModel>> SearchCarAsync(CarSearchingParameters CarSearchingParameters)
        {
            return await iCarBusiness.SearchCarAsync(CarSearchingParameters);
        }
    }
}

