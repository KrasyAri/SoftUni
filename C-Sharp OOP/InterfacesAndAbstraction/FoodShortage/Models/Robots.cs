using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Robots : IIdable
    {
        public Robots(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Id { get; set ; }
        public string Model { get; set; }
    }
}
