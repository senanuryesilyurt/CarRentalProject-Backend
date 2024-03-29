﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
           
            if (CheckCar(rental.CarId).Success && !CheckReturnDate(rental.CarId).Success)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }

            else { return new ErrorResult(Messages.RentalNotAdded); }
           
        }

        public IResult CheckCar(int carId)
        {
            var result = _rentalDal.Get(c => c.CarId == carId);
            if (result != null) { return new SuccessResult(); }
            else { return new ErrorResult(); }
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.Get(c => c.CarId == carId);
            if (result.ReturnDate != null) { return new ErrorResult(); }
            else { return new SuccessResult(); }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.rentalDetailDtos());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.SuccessMessage);
        }
    }
}
