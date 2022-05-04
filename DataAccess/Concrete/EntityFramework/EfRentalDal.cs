using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.rentals
                             join c in context.cars
                             on r.CarId equals c.Id
                             join b in context.brands
                             on c.BrandId equals b.Id
                             join cs in context.customers
                             on r.CustomerId equals cs.Id
                             join u in context.Users
                             on cs.UserId equals u.Id
                             select new RentalDetailsDto
                             {
                                 Id = r.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = b.Name,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
