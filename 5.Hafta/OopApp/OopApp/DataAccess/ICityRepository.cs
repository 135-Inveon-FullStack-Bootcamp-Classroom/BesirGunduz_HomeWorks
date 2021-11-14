using OopApp.Entities;
using System.Collections.Generic;

namespace OopApp.DataAccess
{
    public interface ICityRepository : IAppRepository<City>
    {
        List<CityDetailDto> GetCityDetails();
    }
}
