using LAB1_AutomobileWinform.BusinessObject;
using LAB1_AutomobileWinform.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_AutomobileWinform.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarById(int carId) => CarDBContext.Instance.GetCarById(carId);
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;
        public void AddCar(Car car) => CarDBContext.Instance.Add(car);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
        public void DeleteCar(int carId) => CarDBContext.Instance.Delete(carId);

    }
}
