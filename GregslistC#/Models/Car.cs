using System;
using System.ComponentModel.DataAnnotations;

namespace GregslistC_.Models
{
    public class Car
    {
        internal int id;
        internal string carId;

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}