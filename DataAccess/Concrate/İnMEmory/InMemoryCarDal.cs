using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Car;
        public InMemoryCarDal()
        {
            _Car = new List<Car>
            {
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="BMW"},
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="BMW"},
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="Mercedes"},
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="Mercedes"},
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="opel"},
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="opel"},
                new Car {Id=1,BrandId=10,ColorId=11,DailyPrice=140,ModelYear=2002,Decription="opel"},

            };

        }

        public void Add(Car car)
        {
            _Car.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteCar = _Car.SingleOrDefault(p => p.Id == car.Id);
            _Car.Remove(DeleteCar);

        }

        public Car get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _Car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
            return _Car.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car UpdateCar= _Car.SingleOrDefault(p => p.Id == car.Id);

            UpdateCar.BrandId = car.BrandId;
            UpdateCar.ColorId = car.ColorId;
            UpdateCar.Id = car.Id;
            UpdateCar.DailyPrice = car.DailyPrice;
            UpdateCar.Decription = car.Decription;
            UpdateCar.ModelYear = car.ModelYear;
        }
    }
}
