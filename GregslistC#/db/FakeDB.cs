using System.Collections.Generic;
using GregslistC_.Models;

namespace GregslistC_.db
{
    public class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
    }
}