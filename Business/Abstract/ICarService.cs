using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<List<CarDetailDto>> GetCarByBrandIdDetailDtos(int brandId);
        IDataResult<List<CarDetailDto>> GetCarByColorIdDetailDtos(int colorId);
        IResult AddTransactionalTest(Car car);
    }
}
