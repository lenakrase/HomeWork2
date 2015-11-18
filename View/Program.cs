using System;
using Model;
using System.Drawing;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Лада", 'D');

            car.Color = Color.DarkMagenta;
            try
            {
                Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Нет имени владельца автомобиля " + car.Model);
            }
            Driver newDriver = new Driver(new DateTime(1990, 10, 10), "Вольдемар");

            newDriver.Category = "BC";
            car.ChangeOwner(newDriver, "о777оо");

            newDriver.Category = newDriver.Category.Insert(2, "D");

            car.ChangeOwner(newDriver, "о777оо");
            Console.WriteLine();
            Console.WriteLine("Номер машины " + car.Model + ": " + newDriver.Car.CarNumber);

            Console.WriteLine("Владелец машины " + car.Model + ": " + car.CarPassport.Owner.Name);

            Console.ReadKey();

        }
    }
}
