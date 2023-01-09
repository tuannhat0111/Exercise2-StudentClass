using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2_StudentClass
{
    internal class Student
    {
        public string Name { get; set; }
        private int age;
        private double gpa;

        public int Age { get => age; set => age = value; }
        public double Gpa { set { if (value > 0 && value <= 4) gpa = value; } get { return gpa; } }

        public Student() { }
        public Student(string name, int age, double gpa)
        {
            Name = name;
            this.age = age;
            this.gpa = gpa;
        }

        public string DisplayInformation()
        {
            return $"Student has Name = {Name}, Age = {age}, GPA = {gpa}";
        }

        public override string? ToString()
        {
            return $"Name = {Name}, Age = {age}, GPA = {gpa}";
        }
    }
}
