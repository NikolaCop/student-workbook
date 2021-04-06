using System;
using System.ComponentModel.DataAnnotations;

namespace GregslistC_.Models
{
    public class House
    {
        public House(string name, int bedrooms, int price)
        {
            Name = name;
            Bedrooms = bedrooms;
            Price = price;
        }

        public House()
        {

        }

        public string Name { get; set; }
        public int Bedrooms { get; set; }
        public int Price { get; set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}