using LAB1_AutomobileWinform.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_AutomobileWinform.DataAccess
{
    public class CarDBContext
    {
        //initialize car list
        private static List<Car> CarList = new List<Car>()
        {
            new Car{CarID = 1, CarName = "CRV", Manufacturer = "Honda",
            Price = 30000, ReleaseYear = 2021},
            new Car{CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford",
            Price = 15000, ReleaseYear = 2020}
        };
        //using singleton pattern
        private static CarDBContext instance = null;
        private static readonly object instancelock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Car> GetCarList => CarList;

        public Car GetCarById(int carID)
        {
            Car car = CarList.SingleOrDefault(x => x.CarID == carID);
            return car;
        }

        // add new car
        public void Add(Car car)
        {
            Car p = GetCarById(car.CarID);
            if (p is null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car has already exists...");
            }
        }

        // update car info
        public void Update(Car car)
        {
            Car c = GetCarById(car.CarID);
            if (c is not null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;
            }
            else
            {
                throw new Exception("Car does not exists...");
            }
        }

        public void Delete(int CarID)
        {
            Car p = GetCarById(CarID);
            if (p is not null)
            {
                CarList.Remove(p);
            }
            else
            {
                throw new Exception("Car does not exists...");
            }
        }
    }
}
