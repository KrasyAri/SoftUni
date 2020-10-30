using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.Push("Pesho");
            stack.Push("Gosho");
            stack.Push("Sasho");

            Console.WriteLine(stack.IsEmpty());
            

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
