using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//CarTest();
//ColorTest();

void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());

    var result = colorManager.GetAll();

    if (result.Success==true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.ColorName);

        }
    }  
}

void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    var result = carManager.GetCarDetails();

    if (result.Success == true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.BrandName + "/" + item.DailyPrice);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}


