using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string colour, int battery)
        {
            Model = model;
            Colour = colour;
            Battery = battery;
        }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int Battery { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Colour} {nameof(Tesla)} {this.Model} {this.Battery} Batteries";

        }
    }
}
