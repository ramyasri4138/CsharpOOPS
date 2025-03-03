using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    using System;

    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        // Virtual method to be overridden by derived classes
        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username} with role {Role} has basic access.");
        }
    }

    public class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        // Override the virtual method to provide admin-specific access
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} with role {Role} has access to all features.");
        }
    }

    public class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        // Override the virtual method to provide customer-specific access
        public override void AccessControl()
        {
            Console.WriteLine($"{Username} with role {Role} has limited access.");
        }
    }
}
