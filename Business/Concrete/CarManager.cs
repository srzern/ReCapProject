using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2)
            {
                if (car.DailyPrice > 0)
                {
                    _CarDal.Add(car);
                    Console.WriteLine("{0} Açıklamalı aracınız, {1} lira fiyatı ile eklenmiştir", car.Description, car.DailyPrice);
                }
                else
                {
                    Console.WriteLine("HATA! Aracın günlük fiyatı 0'dan büyük olmalı");
                }
            }
            else
            {
                Console.WriteLine("HATA! Araç açıklaması minimum 2 karakter olmalıdır!");
            }
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

       public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(p => p.ColorId == id);
        }
    }
}
