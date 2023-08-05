namespace Program
{
    class Student
    {
        

        public int StudentId { get; set;}
        public string Name { get; set; }

        public string MyProperty { get; set; }

        public string Address { get; set;}

        public void ShowDetails()
        {
            Console.WriteLine("Student informatiojn");
            Console.WriteLine("StudentId : {0}, Name:{1}, Address:{2}", StudentId, Name, Address); 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 1;
            student.Name = "Test";
            student.Address = "place";
            student.ShowDetails();
        }
    }
}