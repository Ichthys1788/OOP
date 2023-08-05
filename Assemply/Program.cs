using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Assembly
{
    public class AssemblyBaseClass
    {
        private string privatevariable = "private";
        protected string protectedvariable = "protected";
        internal string InternalVariable = "internal";
        public string publicVariable = "public";
        protected internal string protectedInternalVariable = "protected internal";
        
        public void TestAccess()
        {
            //Accessible
            Console.WriteLine(privatevariable);
            Console.WriteLine(protectedvariable);
            Console.WriteLine(InternalVariable);
            Console.WriteLine(publicVariable);
            Console.WriteLine(protectedInternalVariable);
        }
     
    }
    public class AssemblyDerivedClass : AssemblyBaseClass
    {
        public void TestAccessinDirivedclass()
        {
            // Not Accessible
            //Console.WriteLine(privateveariable);

            // Accessible
            Console.WriteLine(protectedvariable);
            Console.WriteLine(InternalVariable);
            Console.WriteLine(publicVariable);
            Console.WriteLine(protectedInternalVariable);
        }

    }
    public class AssemblyOtherClass
    {

        public void TestAccess()
        {
            AssemblyBaseClass objBase = new AssemblyBaseClass();
         /*   Console.WriteLine(objBase.privatevariable);
            Console.WriteLine(objBase.protectedvariable);*/

            Console.WriteLine(objBase.InternalVariable);
            Console.WriteLine(objBase.publicVariable);
            Console.WriteLine(objBase.protectedInternalVariable);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            //AssemblyBaseClass objBase = new AssemblyBaseClass();
            //objBase.TestAccess();

            /*AssemblyDerivedClass objDerivedClass = new AssemblyDerivedClass();
            objDerivedClass.TestAccessinDirivedclass();
            objDerivedClass.TestAccess();*/

            AssemblyOtherClass objOther = new AssemblyOtherClass();
            objOther.TestAccess();
            Console.ReadKey();
        }
    }
    
}