using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            
            _cars = new List<Car> {
             new Car {CarId =1, ColorId =1, Descriptions = "Mercedes",  BrandId=15, DailyPrice=15,  ModelYear = 2010},
             new Car {CarId =2, ColorId =1, Descriptions= "BMW",  BrandId=15, DailyPrice=187425,  ModelYear = 2015},
             new Car {CarId =3, ColorId =3, Descriptions = "Opel",  BrandId=15, DailyPrice=17895,  ModelYear = 2000},
             new Car {CarId =4, ColorId =2, Descriptions = "Audi",  BrandId=15, DailyPrice=1785,  ModelYear = 1998},
             new Car {CarId =5, ColorId =2, Descriptions = "Fiat",  BrandId=15, DailyPrice=1455,  ModelYear = 2015},
             new Car {CarId =6, ColorId =1, Descriptions = "Skoda",  BrandId=10, DailyPrice=1500,  ModelYear = 1960},
             new Car {CarId =7, ColorId =4, Descriptions = "Renault",  BrandId=9, DailyPrice=1005,  ModelYear = 1980}
            };
        }


        public void Add(Car car)
        {
            Console.WriteLine("Eklendi");
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Silindi");

            Car CarToDelete = _cars.SingleOrDefault(Car => Car.CarId == Car.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter=null)
        {
            Console.WriteLine("Liste geldi");
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            Console.WriteLine("Id'ye göre Ekrana geldi");

            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Console.WriteLine("Güncellendi");
            Car CarToUpdate = _cars.SingleOrDefault(Car => Car.CarId== car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Descriptions = car.Descriptions;
        }
    }
}



