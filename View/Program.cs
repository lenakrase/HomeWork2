using System;
using Model;
using System.Drawing;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Лада", "D");

           
            Driver driver = new Driver(new DateTime(1990, 10, 10), "Вольдемар");

            driver.Category = "BC";
            car.Color = Color.DarkMagenta;

            try
            {
                Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Нет имени владельца автомобиля ");
            }

            try
            {
            car.ChangeOwner(driver, "о777оо");
            }
            catch (MyException e)
            {
                
                Console.WriteLine(e.Message);
            }

            driver.Category = driver.Category.Insert(2, "D");

            car.ChangeOwner(driver, "о777оо");
            Console.WriteLine();
            Console.WriteLine("Номер машины : "  + driver.Car.CarNumber);
            Console.WriteLine("Владелец машины : " +  car.CarPassport.Owner.Name);

            Console.ReadKey();

        }
    }
}
