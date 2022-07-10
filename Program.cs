using System;

namespace ConsoleApp21
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region
            //Create a C# program that requests three names of people from the user and stores them in an array 
            //of objects of type Person. To do this, first create a Person class that has a Name property of
            //type string and override the ToString() method.
            #endregion
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(45);
          
            student.ShowAge();
            student.Greet();

            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.SetAge(12);
            teacher.Explain();
            
        }
    }
}
