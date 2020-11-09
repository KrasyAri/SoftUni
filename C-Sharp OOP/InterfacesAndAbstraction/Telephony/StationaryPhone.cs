using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Telephony.Interfaces;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                return "Invalid number!";
            }

            return $"Dialing... {phoneNumber}";
        }
    }
}
