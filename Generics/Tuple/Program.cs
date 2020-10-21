using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split();
            string personFullName = $"{firstTokens[0]} {firstTokens[1]}";
            string personAdress = firstTokens[2];

            Tuple<string, string> personInfoTuple = new Tuple<string, string>(personFullName, personAdress);

            string[] secondTokens = Console.ReadLine().Split();
            string name = secondTokens[0];
            int beerAmount = int.Parse(secondTokens[1]);

            Tuple<string, int> PersonTwoInfo = new Tuple<string, int>(name, beerAmount);

            string[] thirdTokens = Console.ReadLine().Split();
            int intNumber = int.Parse(thirdTokens[0]);
            double doubleNum = double.Parse(thirdTokens[1]);

            Tuple<int, double> PersonThirdInfo = new Tuple<int, double>(intNumber, doubleNum);

            Console.WriteLine(personInfoTuple);
            Console.WriteLine(PersonTwoInfo);
            Console.WriteLine(PersonThirdInfo);
           
        }
    }
}
