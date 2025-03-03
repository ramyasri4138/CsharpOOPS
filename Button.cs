using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public class Button
    {
        // Delegate for the OnClick event
        public delegate void ClickEventHandler(object sender, EventArgs e);

        // Event based on the delegate
        public event ClickEventHandler OnClick;

        // Method to trigger the OnClick event
        public void Click()
        {
            Console.WriteLine("Button was clicked.");
            OnClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
