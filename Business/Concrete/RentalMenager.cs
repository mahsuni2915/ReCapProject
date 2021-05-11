using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public  class RentalMenager : IRentalService

    {
        IRentalDal _RentalDal;
        public RentalMenager(IRentalDal RentalDal)
        {
            _RentalDal = RentalDal;
        }
        public IResult add(Rental rent)
        {
            if(rent.ReturnDate != null)
            {
                return new ErrorResult(Messages.CarStateFalse);
            }
            _RentalDal.Add(rent);
            return new SuccessResult(Messages.CarStateTrue);
        }

        public IResult Delete(Rental rent)
        {
            _RentalDal.Delete(rent);
            return new SuccessResult(Messages.CarRentDeleted);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            
            return new SuccessDataResult<List<Rental>>(_RentalDal.GetAll(), Messages.RentalList);
        }

        public IResult Update(Rental rent)
        {
            _RentalDal.Update(rent);
            return new SuccessResult(Messages.CarRentUpdated);
        }
    }
}
