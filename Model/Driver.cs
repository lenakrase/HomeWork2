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

        public int Experience
        {
            get
            {
                TimeSpan experience = DateTime.Now - LicenceDate.Date;
                return experience.Days / 365;
            }
        }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                    Car = car;
            }
            else
            {
                throw new MyException("Водитель не обладает нужной категорией");
            }

        }
    }
}
