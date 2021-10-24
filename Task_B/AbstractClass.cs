using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class AbstractClass
    {
        //Интерфейс определяющий методы для абстрактного класса 
        interface ICar
        {
            void InformationDisplay();
        }

        //Абстрактный класс таксопарка
        public abstract class Car : ICar
        {
            //Автосвойства
            public virtual string TaxiType
            {
                get;
            }
            public virtual string Brand
            {
                get;
            }
            public virtual double Price
            {
                get;
            }
            public virtual double Fuel
            {
                get;
            }
            public virtual int Speed
            {
                get;
            }
            //Реализация методов
            public void InformationDisplay()
            {
                Console.WriteLine("{0,-25} {1,-25} {2,-25} {3,-25}", TaxiType, Brand, Fuel, Speed);
            }

        }
    }
}