using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class TaxiStation
    {
        //Создание массива объектов
        AbstractClass.Car[] arrayOfCars = new AbstractClass.Car[]
        {new Cars.Economy(), new Cars.Comfort(), new Cars.Business(),
         new Cars.StationWagon(), new Cars.Minivan(), new Cars.Minibus(), new Cars.Premium() };

        //Метод вывода видов такси
        public void DisplayInfo()
        {
            foreach (var car in arrayOfCars)
            {
                car.InformationDisplay();
            }
        }
        //Метод подсчёта общей стоимости автопарка
        public void TaxiFleetCost()
        {
            double price = 0;
            foreach (var car in arrayOfCars)
                price += car.Price;
            Console.WriteLine($"Общая стоимость автопарка: {price}$");
        }
        //Метод сортировки автомобилей по расходу топлива
        public void SortByPrice()
        {
            Array.Sort(arrayOfCars, new FuelСonsumption());
        }
        //Метод вывода информации об отсортированных автомобилях
        public void OutputSortedCar()
        {
            foreach (var car in arrayOfCars)
            {
                Console.WriteLine("{0,-25} {1,-25}", car.Brand, car.Fuel);
            }
            Console.WriteLine();
        }
        //Метод поиска автомобилей в компании, соответствующих заданному диапазону параметров скорости
        public void SearchBySpeedRange(double value1, double value2)
        {
            bool flag = false;
            foreach (var car in arrayOfCars)
            {
                if (value1 >= value2)
                {
                    if (car.Speed <= value1 && car.Speed >= value2)
                    {
                        car.InformationDisplay();
                        flag = true;
                    }
                }
                else
                {
                    if (car.Speed >= value1 && car.Speed <= value2)
                    {
                        car.InformationDisplay();
                        flag = true;
                    }
                }
            }
            if (!flag) Console.WriteLine("В заданном диапазоне автомобилей нет!");
        }
    }
}
