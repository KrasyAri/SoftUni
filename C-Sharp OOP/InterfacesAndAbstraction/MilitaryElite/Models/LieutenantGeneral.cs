using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public ICollection<Private> Privates { get; set; }
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<Private>();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine("Privates:");

            foreach (var item in this.Privates)
            {
                stringBuilder.AppendLine(" "+ item.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
