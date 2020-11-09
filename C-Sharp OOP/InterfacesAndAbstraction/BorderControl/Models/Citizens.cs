using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : IID
    {
        public Citizens(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        
    }
}
