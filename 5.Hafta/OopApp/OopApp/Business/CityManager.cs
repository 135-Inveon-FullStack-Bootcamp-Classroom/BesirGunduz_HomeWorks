using OopApp.DataAccess;
using OopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OopApp.Business
{
    class CityManager : ICityRepository
    {
        private readonly ICityRepository _cityRepository;
        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public void Add(City entity)
        {
            _cityRepository.Add(entity);
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
