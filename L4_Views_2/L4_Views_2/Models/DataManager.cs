using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L4_Views_2.Models
{
    public static class DataManager
    {
        static List<Car> cars = new List<Car>()
        {
            new Car { Id = 1, Brand = "Ferrari",    Doors = 2, TopSpeed = 175 },
            new Car { Id = 2, Brand = "Toyota",     Doors = 4, TopSpeed = 260 },
            new Car { Id = 3, Brand = "BMW",        Doors = 2, TopSpeed = 300 },
            new Car { Id = 4, Brand = "Volkswagen", Doors = 3, TopSpeed = 250 },
        };

        public static CarsIndexVM[] ListCars()
        {
            return cars
                .Select(o => new CarsIndexVM()
                {
                    Brand = o.Brand,
                    ShowAsFast = o.TopSpeed > 250,
                })
                .ToArray();
        }

        public static void AddCar(CarsCreateVM viewModel)
        {
            var newCar = new Car()
            {
                Id = cars.Max(o => o.Id) + 1,
                Brand = viewModel.Brand,
                Doors = viewModel.Doors,
                TopSpeed = viewModel.TopSpeed,
            };

            cars.Add(newCar);
        }
    }
}
