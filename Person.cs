using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Person
    {
        public string Name1 { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name1 = name;
            Age = age;
        }

        // Virtual method to be overridden
        public virtual string GetDetails()
        {
            return $"Name: {Name1}, Age: {Age}";
        }
    }

    public class Student1 : Person
    {
        public int RollNo { get; set; }

        public Student1(string name1, int age, int rollNo) : base(name1, age)
        {
            RollNo = rollNo;
        }

        // Override the virtual method to display student-specific details
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Roll No: {RollNo}";
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name1, int age, string subject) : base(name1, age)
        {
            Subject = subject;
        }

        // Override the virtual method to display teacher-specific details
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Subject: {Subject}";
        }
    }
}
