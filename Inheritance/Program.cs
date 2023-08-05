using System;

namespace Inheritance // Note: actual namespace depends on the project name.
{
    // Single level inheritance
    /*    class Vehicle
        {
            string number;
            string owner;
        }
        class Car : Vehicle
        {
            int noOfDoors;
        }*/

    // Multi levels of inheritance
    /*  class Vehicle // Base class
     {
         string number;
         string owner;
     }
     class FourWheeler : Vehicle // Derived class
     {
         string type;

     }
     class Car : FourWheeler // Derived class
     {
         int noOfDoors;
     }*/

    //herirachical inheritance
    class Vehicle // Base class
    {
        string number;
        string owner;
    }
    class FourWheeler : Vehicle // Derived class
    {
        string type;

    }
    class Car : FourWheeler // Derived class
    {
        int noOfDoors;
    }
    class Tractor : FourWheeler // Derived class
    {
        int noOfAxels;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}