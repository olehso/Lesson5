using System;

//9.Таксопарк.Определить иерархию автомобилей. Создать таксопарк. 
//  Подсчитать стоимость автопарка.Провести сортировку автомобилей парка по расходу топлива.
//  Найти автомобиль в компании, соответствующий заданному диапазону параметров скорости.

//Каталог(виды) машин(авто) такси
//эконом, комфорт, бизнес-класс(до трёх пассажиров);
//машины универсал(для перевозки большего количества багажа);
//автомобили минивэны(от 5 – ти до 8 - ти пассажирских мест);
//микроавтобусы(до 20 пассажирских мест).


namespace Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiStation Taxi = new TaxiStation();

            Console.WriteLine("ТАКСОПАРК: \n");
            Console.WriteLine("{0,-25} {1,-25} {2,-25} {3,-25}\n", "Taxi type", "Brand", "Fuel(l)", "Speed(kph)");
            Taxi.DisplayInfo();

            Console.WriteLine();
            Taxi.TaxiFleetCost();

            Console.WriteLine("\nСортировка автомобилей парка по расходу топлива (литр) на 100 км: ");
            Console.WriteLine("\n{0,-25} {1,-25}\n", "Brand", "Fuel(l)");
            Taxi.SortByPrice();
            Taxi.OutputSortedCar();
            Console.WriteLine();

            Console.WriteLine("Для поиска автомобилей в заданном диапазоне введите левую и правую границы.");
            Console.Write("\nВведите левую границу: ");
            double value1 = double.Parse(Console.ReadLine());
            Console.Write("Введите правую границу: ");
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nАвтомобили в заданном диапазоне: ");
            Taxi.SearchBySpeedRange(value1, value2);
        }
    }
}