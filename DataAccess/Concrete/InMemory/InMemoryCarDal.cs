using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{CarId=1, BrandId=1, ModelYear=2020, DailyPrice=2000, Description="BMW"},
            new Car{CarId=2, BrandId=1, ModelYear=2000, DailyPrice=500, Description="Ford"},
            new Car{CarId=3, BrandId=2, ModelYear=2010, DailyPrice=1000, Description="Toyota"},
            new Car{CarId=4, BrandId=2, ModelYear=1998, DailyPrice=300, Description="Doğan SLX"},
            new Car{CarId=5, BrandId=3, ModelYear=1994, DailyPrice=100, Description="Toros"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }

    }

