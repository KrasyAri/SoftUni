using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public ICollection<Mission> Missions { get; set; }
        public Commando(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<Mission>();
        }

      
        public void CompleteMission(Mission mission)
        {
            mission.State = "Finished";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {Math.Round(base.Salary, 2):f2}");
            stringBuilder.AppendLine($"Corps: {base.Corps}");
            stringBuilder.AppendLine("Missions:");

            foreach (var item in this.Missions)
            {
                stringBuilder.AppendLine(" " + item.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
