using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;
using WebCar.Common.Models;

namespace WebCar.WebApp._4_DataAcess.IRepository
{
    public interface ICarRepository
    {
        Task<List<CarModel>> SearchCarAsync(CarSearchingParameters CarSearchingParameters);
    }
}
