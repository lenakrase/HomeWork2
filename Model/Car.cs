using System;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public string Model { get; }
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        public string Category { get; }

        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            driver.OwnCar(this);
            CarPassport.Owner = driver;
            CarNumber = carNumber;
        }
    }
}