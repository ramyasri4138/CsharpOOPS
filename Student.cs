using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Student
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Roll No cannot be negative.");
                }
                rollNo = value;
            }
        }

        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
    }

}
