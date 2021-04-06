using System;
using System.ComponentModel.DataAnnotations;

namespace GregslistC_.Models
{
    public class Car
    {
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
        public int Year { get; set; }
    }
}