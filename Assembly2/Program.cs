// See https://aka.ms/new-console-template for more information
using System;
using Assembly;
namespace Assembly1 // Note: actual namespace depends on the project name.
{
    public class Assembl2DerivedClass : AssemblyBaseClass
    {
        // Not Accessible
        //Console.WriteLine(privatveariable);
        public void TestAccessInDerivedClass()
        {
            // Not Accessible
        /*    Console.WriteLine(privatveariable);
            Console.WriteLine(InternalVariable);*/

            // Accessible
            Console.WriteLine(protectedvariable);
            Console.WriteLine(publicVariable);
            Console.WriteLine(protectedInternalVariable);
        }
        
    }
    public class Assembl2OtherClass 
    {
        // Not Accessible
        //Console.WriteLine(privatveariable);
        public void TestAccess()
        {
            AssemblyBaseClass objBase = new AssemblyBaseClass();
            // Not Accessible
            /*Console.WriteLine(objBase.privatveariable);
            Console.WriteLine(objBase.InternalVariable);
            Console.WriteLine(objBase.protectedvariable);
            Console.WriteLine(objBase.protectedInternalVariable);*/

            // Accessible
            Console.WriteLine(objBase.publicVariable);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Assembl2DerivedClass objDerived = new Assembl2DerivedClass();
            objDerived.TestAccessInDerivedClass();
            objDerived.TestAccess();*/

            Assembl2OtherClass ObjOther = new Assembl2OtherClass();

            ObjOther.TestAccess();
            Console.ReadKey();

        }
    }
}