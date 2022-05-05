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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.cars
                             join b in context.brands
                             on c.BrandId equals b.Id
                             join cl in context.colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 BrandName = b.Name,
                                 ColorName = cl.Name,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.cars
                             join b in context.brands
                             on c.BrandId equals b.Id
                             join cl in context.colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 BrandName = b.Name,
                                 ColorName = cl.Name,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice
                             };
                if(filter == null)
                {
                    return result.ToList();
                }
                return result.Where(filter).ToList();   
            }
        }
    }
}
