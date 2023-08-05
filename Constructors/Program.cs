using System;

namespace Constructor // Note: actual namespace depends on the project name.
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string College { get; set; }
        // Default constructor
         public Student()
        {
            Name = "David";
            College = "Stuff";
            Id = 12313;
        }
        public Student(int id,string Came)
        {
            this.Id = id;
            this.Name = Came;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   Student student = new Student();
            Console.WriteLine("Student Id : {0}, Name: {1}, College: {2} ", student.Id, student.Name, student.College);*/
         Student student = new Student(123,"sdf");
            Console.WriteLine("Student Id : {0}, Name: {1}, College: {2}", student.Id, student.Name, student.College);
            Console.ReadKey();
        }
    }
}