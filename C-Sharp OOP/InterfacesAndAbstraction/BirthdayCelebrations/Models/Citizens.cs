using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    public class Citizens : IIdable, IBirthable
    {
        public Citizens(string id, int age, string birthDate, string name)
        {
            Id = id;
            Age = age;
            BirthDate = birthDate;
            Name = name;
        }

        public string Id { get; set; }
        
        public int Age { get; set; }
        public string BirthDate { get ; set ; }

        public string Name { get; set; }


    }
}
