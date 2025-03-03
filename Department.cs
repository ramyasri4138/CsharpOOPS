using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string departmentName, Manager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }

        // Shallow copy method
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep copy method
        public Department DeepCopy()
        {
            Department newDepartment = (Department)this.MemberwiseClone();
            newDepartment.Manager = new Manager(this.Manager.Name);
            return newDepartment;
        }

        public override string ToString()
        {
            return $"Department: {DepartmentName}, Manager: {Manager.Name}";
        }
    }

    

}
