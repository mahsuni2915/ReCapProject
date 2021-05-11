using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EFCarDAl : EfEntityRepositoryBase<Car, CARSaleContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CARSaleContext contex = new CARSaleContext())

            {
                var result = from c in contex.Cars
                             join b in contex.Brands on c.BrandId equals b.BrandId
                             join p in contex.Colors on c.ColorId equals p.ColorId
                             select new CarDetailDto
                             { BrandName = b.BrandName, ColorName = p.ColorName, DailyPrice = c.DailyPrice, Decription = c.Decription };
                return result.ToList();
            }

        }
    }
}