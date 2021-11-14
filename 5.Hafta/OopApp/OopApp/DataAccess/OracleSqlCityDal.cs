using OopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OopApp.DataAccess
{
    public class OracleSqlCityDal : ICityRepository
    {
        public void Add(City entity)
        {
            Console.WriteLine("OracleSql - City added");
        }

        public void Delete(City entity)
        {
            throw new NotImplementedException();
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

        public List<CityDetailDto> GetCityDetails()
        {
            throw new NotImplementedException();
        }
    }
}
