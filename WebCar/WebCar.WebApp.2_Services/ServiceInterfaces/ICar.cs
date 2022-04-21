using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;
using WebCar.Common.Models;

namespace WebCar.WebApp._2_Services.ServiceInterfaces
{
    public  interface ICar
    {
        Task<List<CarModel>> SearchCarAsync(CarSearchingParameters carSearchingParameters);
    }
}
