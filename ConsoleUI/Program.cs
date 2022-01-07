using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

VehicleManager vehicleManager = new VehicleManager(new EfCarDal());

foreach (var item in vehicleManager.GetCarsByBrandId(1))
{
    Console.WriteLine(item.Description);

}
