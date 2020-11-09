using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public ICollection<Repair> Repairs { get; set; }

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            :base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<Repair>();
        }

       
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {Math.Round(base.Salary, 2):f2}");
            stringBuilder.AppendLine($"Corps: {base.Corps}");
            stringBuilder.AppendLine("Repairs:");

            foreach (var item in this.Repairs)
            {
                stringBuilder.AppendLine(" " + item.ToString());
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
