using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Cars
    {
        //Классы определённых овощей - наследников абстрактного класса
        public class Economy : AbstractClass.Car
        {
            //переопределение базовых свойств
            public override string TaxiType => "Такси Эконом класса";
            public override string Brand => "Hyundai Accent";
            public override double Price => 8399;
            public override double Fuel => 9.8;
            public override int Speed => 190;
        }
        public class Comfort : AbstractClass.Car
        {
            public override string TaxiType => "Такси Комфорт класса";
            public override string Brand => "Toyota Camry";
            public override double Price => 30470;
            public override double Fuel => 8.7;
            public override int Speed => 220;
        }
        public class Business : AbstractClass.Car
        {
            public override string TaxiType => "Такси Бизнес класса";
            public override string Brand => "Mercedes-Benz E-class";
            public override double Price => 68099;
            public override double Fuel => 8.6;
            public override int Speed => 250;
        }

        public class StationWagon  : AbstractClass.Car
        {
            public override string TaxiType => "Такси Универсал";
            public override string Brand => "Ford Focus";
            public override double Price => 21400;
            public override double Fuel => 10.7;
            public override int Speed => 190;
        }
        public class Minivan : AbstractClass.Car
        {
            public override string TaxiType => "Такси Минивен";
            public override string Brand => "Mitsubishi Grandis";
            public override double Price => 6700;
            public override double Fuel => 10.0;
            public override int Speed => 190;
        }
        public class Minibus : AbstractClass.Car
        {
            public override string TaxiType => "Такси Микроавтобус";
            public override string Brand => "Nissan Primastar";
            public override double Price => 9000;
            public override double Fuel => 6.9;
            public override int Speed => 200;
        }
        public class Premium : AbstractClass.Car
        {
            public override string TaxiType => "Премиум Такси";
            public override string Brand => "Mercedes-Maybach S-class";
            public override double Price => 194949;
            public override double Fuel => 16.9;
            public override int Speed => 250;
        }
    }
}