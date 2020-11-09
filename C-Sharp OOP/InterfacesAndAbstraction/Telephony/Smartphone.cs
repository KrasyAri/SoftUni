using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Interfaces;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        
        public string Brawsing(string url)
        {
            
            if (url.Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                return "Invalid number!";
            }

            return $"Calling... {phoneNumber}";
           
        }
    }
}
