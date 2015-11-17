using System;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(string model, char category)
        {
            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public string Model { get; }
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        public char Category { get; }

        public CarPassport CarPassport { get; }

        public void ChangeOwner(Driver newDriver, string carNumber)
        {

            CarPassport.Owner = newDriver;
            newDriver.OwnCar(this);
            CarNumber = carNumber;

        }
    }
}