using System;

namespace helloapp
{
    class Program
    {
         
        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }

        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone");
            GreetBlack();
            GreetWhite();
        }
    }
}
