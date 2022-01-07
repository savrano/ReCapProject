using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryVehicleDAL : IVehicleDal
    {
        List<Car> _cars;
        public InMemoryVehicleDAL()
        {
            _cars = new List<Car>
            {
                new Car{CarID=1,BrandID=1,ColorID=1,DailyPrice=100,ModelYear=1996,Description="Mercedes"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Delete(Car car)
        {
            Car carDelete = null;
            carDelete= _cars.FirstOrDefault(p=> p.CarID==car.CarID);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(int carId)
        {
            return _cars.Where(p => p.CarID == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate=null;
            carUpdate = _cars.FirstOrDefault(p => p.CarID == car.CarID);
            carUpdate.BrandID=car.BrandID;
            carUpdate.ModelYear=car.ModelYear;
            carUpdate.Description=car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
