using OopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OopApp.DataAccess
{
    public class EFCityDal : ICityRepository
    {
        public void Add(City entity)
        {
            Console.WriteLine("SqlServer - City added");
        }

        public City Get(Expression<Func<City, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll(Expression<Func<City, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public List<CityDetailDto> GetCityDetails()
        {
            throw new NotImplementedException();
        }
    }
}
