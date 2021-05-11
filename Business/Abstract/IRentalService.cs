﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {

        IDataResult<List<Rental>> GetAll();
        IResult add(Rental rent);
        IResult Update(Rental rent);
        IResult Delete(Rental rent);
    }
    
}
