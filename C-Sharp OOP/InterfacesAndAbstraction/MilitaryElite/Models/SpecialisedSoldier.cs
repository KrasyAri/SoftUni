using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            :base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; private set; }
    }
}
