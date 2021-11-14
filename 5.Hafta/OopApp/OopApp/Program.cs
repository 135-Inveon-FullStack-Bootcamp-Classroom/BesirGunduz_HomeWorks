using OopApp.Business;
using OopApp.DataAccess;
using OopApp.Entities;
using System;

namespace OopApp
{
    class Program
    {
        // Solid'in O'su. Geliştirmeye açık, değişime kapalı
        static void Main(string[] args)
        {
            var cityManager = new CityManager(new EFCityDal());
            cityManager.Add(new City());

            var cityManager2 = new CityManager(new MySqlCityDal());
            cityManager2.Add(new City());

            var cityManager3 = new CityManager(new OracleSqlCityDal());
            cityManager3.Add(new City());

            Console.ReadKey();
        }
    }
}
