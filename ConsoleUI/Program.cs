using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//CarTest();
//ColorTest();
//RentalTest();
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

void RentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    var result = rentalManager.GetCarDetails();
    if (result.Success==true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.FirstName + " "+ item.LastName + " / " + item.CompanyName + " / " + item.Description + " / " + item.RentDate + " / " + item.ReturnDate);

        }
    }
}


