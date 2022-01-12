using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental entity)
        {
            var result = CheckReturnDate(entity);

            if (result.Success==false)
            {
                return new ErrorResult();
            }
            _rentalDal.Add(entity);
            return new SuccessResult();
        }

        public IResult CheckReturnDate(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.RentalId == id));
        }

        public IDataResult<List<RentalDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult();
        }
    }
}
