using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeCars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int BHP { get; set; }
        public int Price { get; set; }
        public string[] Pictures { get; set; }

        public Car()
        {
            Pictures = new string[] { };
        }

    }
}