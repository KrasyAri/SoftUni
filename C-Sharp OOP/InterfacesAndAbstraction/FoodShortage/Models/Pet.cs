using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Pet : IBirthable
    {
       
        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string BirthDate { get; set; }
    }
}
