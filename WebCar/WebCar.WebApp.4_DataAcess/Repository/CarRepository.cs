using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.Common.Enums;
using WebCar.Common.Models;
using WebCar.WebApp._4_DataAcess.Entities;
using WebCar.WebApp._4_DataAcess.IRepository;

namespace WebCar.WebApp._4_DataAcess.Repository
{
    public class CarRepository : BaseRepository, ICarRepository

    {
        public CarRepository(Context _context) : base(_context) { }

        public async Task<List<CarModel>> SearchcarAsync(CarSearchingParameters carSearchingParameters)
        {
            IQueryable<CarEntity> CarQuery = (IQueryable<CarEntity>)_context.CarDbSet.OrderBy(m => m.CarName);

            return await CarQuery.Select(m => new CarModel
            {
                Id = m.Id,
                CarName = m.CarName,
                Carmodel = m.Carmodel,
                CarManufacturer = m.CarManufacturer,
                CarColor = CarTypes.Red,
                CarReleaseDate = m.CarReleaseDate
            }
              ).ToListAsync();
        }

     
        }
    }





        




    



//        public Task<List<CarTypes>> SearchCarAsync(CarSearchingParameters CarSearchingParameters)
//        {
//            IQueryable<CarEntity> CarQuery = (IQueryable<CarEntity>)_context.MovieDbSet.OrderBy(m => m.Title);

//            return await CarQuery.Select(m => new Movie
//            {
//                Id = m.Id,
//                TypeOfMovie = (MovieType)m.TypeOfMovie,
//                Title = m.Title,
//                ReleaseDate = m.ReleaseDate
//            }).ToListAsync();
//        }
//    }
//}
