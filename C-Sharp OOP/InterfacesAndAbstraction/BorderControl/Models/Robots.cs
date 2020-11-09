using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots : IID
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
