// See https://aka.ms/new-console-template for more information

using System;
using System.Threading.Tasks;

namespace StaticAndPrivate // Note: actual namespace depends on the project name.
{
    public class Example
    {
        private static int counter;

        // private constructor
        private Example()
        {
            counter = 10;
        }
        
        //Static constructor
        static Example()
        {
            counter = 20;
        }
        //Public constructor

        public Example(int Counter)
        {
            counter = Counter + counter;
        }
        public static int GetCounter()
        {
            return ++counter;
        }
        
        // public constructor
        public class NestedExample
        {
            public void Test()
            {
                //Internal instance
                Example ex = new Example();
               
            }

        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            // External instance

            Example ex = new Example(10);

            Console.WriteLine("Counter : {0} ", Example.GetCounter());
            Console.ReadKey();
        }
    }
}