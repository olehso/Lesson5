using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class FuelСonsumption : IComparer<AbstractClass.Car>
    {
        public int Compare(AbstractClass.Car car1, AbstractClass.Car car2)
        {
            //Cравнивает объекты в зависимости от значения топлива
            return car1.Fuel.CompareTo(car2.Fuel);
        }
    }
}