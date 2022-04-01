using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalsDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id));
        }

        public IResult Insert(Rental rental)
        {
            var carControl = _rentalDal.GetAll(p => p.CarId == rental.CarId && (p.ReturnDate == null || p.ReturnDate > rental.ReturnDate));
            if(carControl.Count > 0)
            {    
                return new ErrorResult(Messages.RentalInsertError);          
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalInsertSuccess);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalsUpdate);
        }
    }
}
