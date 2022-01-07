using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _iVehicleDal ;

        public VehicleManager(IVehicleDal iVehicleDal)
        {
            _iVehicleDal = iVehicleDal;
        }

        public List<Car> GetAll()
        {
            return _iVehicleDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _iVehicleDal.GetAll(p=> p.BrandID == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _iVehicleDal.GetAll(p => p.ColorID == colorId);
        }
    }
}
