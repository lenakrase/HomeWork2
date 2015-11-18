using System;
using System.Linq;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        public DateTime LicenceDate { get; }
        public string Name { get; }
        public string Category { get; set; }

        public int Expirience => DateTime.Now.Year - LicenceDate.Year;
        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
                if (Category.Contains(car.Category))
                {
                    Car = car;
                }
            else
            {
                Console.WriteLine("Водитель не обладает нужной категорией");
            }

        }
    }
}
