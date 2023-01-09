using System;

namespace Exercise2_StudentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Triet", 21, 9);
            Student student2 = new Student("Nhat", 21, 8.5);

            Console.WriteLine(student1.DisplayInformation());
            Console.WriteLine(student2.ToString());
            Console.ReadKey();
        }
    }
}
