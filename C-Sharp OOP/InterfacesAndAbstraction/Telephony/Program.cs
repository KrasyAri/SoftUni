using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] phones = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] webs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            for (int i = 0; i < phones.Length; i++)
            {
                if (phones[i].Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Call(phones[i]));


                }
                else
                {
                    Console.WriteLine(smartphone.Call(phones[i]));
                }
               
            }

            for (int j = 0; j < webs.Length; j++)
            {
                Console.WriteLine(smartphone.Brawsing(webs[j]));
            }


        }

    }
}
