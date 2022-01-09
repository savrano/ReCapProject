using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//CarTest();
//ColorTest();
//BrandTest();

void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());

    foreach (var item in colorManager.GetAll())
    {
        Console.WriteLine(item.ColorName);

    }
}
void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());

    foreach (var item in brandManager.GetAll())
    {
        Console.WriteLine(item.BrandName);

    }
}

void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var item in carManager.GetCarDetails())
    {
        Console.WriteLine(item.BrandName + "/" + item.ColorName +"/" + item.DailyPrice);

    }
}


