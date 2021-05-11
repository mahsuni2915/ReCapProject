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
    public class CarImageManager: ICarImageService
    {
        ICarImageDal _CarImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _CarImageDal = carImageDal;

        }
        public IResult add(CarImage carImage)
        {

            _CarImageDal.Add(carImage);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            _CarImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_CarImageDal.GetAll(), Messages.Carlisted);
        }



        public IResult Update(CarImage carImage)
        {
            _CarImageDal.Update(carImage);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}

