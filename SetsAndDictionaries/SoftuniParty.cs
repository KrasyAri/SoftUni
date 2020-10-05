using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string reservationNums = Console.ReadLine();

            HashSet<string> vipReservarions = new HashSet<string>();
            HashSet<string> regReservarions = new HashSet<string>();

            while (reservationNums != "END")
            {
                if (reservationNums[0] >= 48 && reservationNums[0] <= 57)
                {
                    if (!vipReservarions.Contains(reservationNums))
                    {
                        vipReservarions.Add(reservationNums);
                    }

                }
                else
                {
                    if (!regReservarions.Contains(reservationNums))
                    {
                        regReservarions.Add(reservationNums);
                    }

                }

                if (reservationNums == "PARTY")
                {
                    while (reservationNums != "END")
                    {
                        if (reservationNums[0] >= 48 && reservationNums[0] <= 57)
                        {
                            vipReservarions.Remove(reservationNums);

                        }
                        else
                        {
                            regReservarions.Remove(reservationNums);
                        }
                        
                        reservationNums = Console.ReadLine();
                    }

                    if (reservationNums == "END")
                    {
                        break;
                    }
                }

                reservationNums = Console.ReadLine();
            }


            int count = regReservarions.Count + vipReservarions.Count;

            Console.WriteLine(count);
            if (vipReservarions.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,vipReservarions));
            }

            if (regReservarions.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, regReservarions));
            }
            
        }
    }
}
