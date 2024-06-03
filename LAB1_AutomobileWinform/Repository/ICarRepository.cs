using LAB1_AutomobileWinform.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_AutomobileWinform.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int carId);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
