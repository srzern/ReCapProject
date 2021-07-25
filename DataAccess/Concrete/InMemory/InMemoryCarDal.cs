using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1,  BrandId=1, ColorId=1, ModelYear=2018, Description="Really good car. No crash, no paint...", DailyPrice=1240000},
                new Car{ Id=2, BrandId=1, ColorId=4,ModelYear=2020, Description="Perfect, Perfect", DailyPrice=2440000},
                new Car{ Id=3, BrandId=2, ColorId=3, ModelYear=2005, Description="Not bad", DailyPrice=140000},
            new Car{ Id=4, BrandId=3, ColorId=1, ModelYear=2021, Description="New Tesla", DailyPrice=9940000},
            new Car{ Id=5, BrandId=5, ColorId=1, ModelYear=1999, Description="Still Work", DailyPrice=24000}

        };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(p=> p.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> getAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
        }
    }
}
