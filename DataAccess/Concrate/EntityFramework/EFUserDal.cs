﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
   public class EFUserDal:EfEntityRepositoryBase<User ,CARSaleContext>,IUserDal
    {

    }
}
