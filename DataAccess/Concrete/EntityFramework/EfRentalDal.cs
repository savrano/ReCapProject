using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (ReCapContext db = new ReCapContext())
            {
                var result = from r in db.Rentals
                             join c in db.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in db.Users
                             on c.UserId equals u.UserId
                             join ca in db.Cars
                             on r.CarId equals ca.CarID
                             select new RentalDetailsDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = c.CompanyName,
                                 Description = ca.Description,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
