﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{

        public interface IRentalService
        {
            IDataResult<List<Rental>> GetAll();
            IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId);
            IResult CheckReturnDate(int carId);
            IResult UpdateReturnDate(int carId);
            IDataResult<Rental> GetById(int id);
            IResult Add(Rental rental);
            IResult Update(Rental rental);
            IResult Delete(Rental rental);

    }
    
}
