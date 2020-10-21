using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split();
            string personFullName = $"{firstTokens[0]} {firstTokens[1]}";
            string personAdress = firstTokens[2];
            string personCity = firstTokens[3];

            Tuple<string, string, string> personInfoTuple = new Tuple<string, string, string>(personFullName, personAdress, personCity);

            string[] secondTokens = Console.ReadLine().Split();
            string name = secondTokens[0];
            int beerAmount = int.Parse(secondTokens[1]);
            bool isDrunk = false;
            if (secondTokens[2] == "drunk")
            {
                isDrunk = true;
            }

            Tuple<string, int, bool> PersonTwoInfo = new Tuple<string, int, bool>(name, beerAmount, isDrunk);

            string[] thirdTokens = Console.ReadLine().Split();
            string namePerson = thirdTokens[0];
            double bankAmount = double.Parse(thirdTokens[1]);
            string bankName = thirdTokens[2];

            Tuple<string, double, string> PersonThirdInfo = new Tuple<string, double, string>(namePerson, bankAmount, bankName);

            Console.WriteLine(personInfoTuple);
            Console.WriteLine(PersonTwoInfo);
            Console.WriteLine(PersonThirdInfo);
           
        }
    }
}
