using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public sealed class SecuritySystem
    {
        public string SystemName { get; set; }
        public bool IsActive { get; set; }

        public SecuritySystem(string systemName, bool isActive)
        {
            SystemName = systemName;
            IsActive = isActive;
        }

        public void Activate()
        {
            IsActive = true;
            Console.WriteLine($"{SystemName} is now active.");
        }

        public void Deactivate()
        {
            IsActive = false;
            Console.WriteLine($"{SystemName} is now inactive.");
        }
    }


}
