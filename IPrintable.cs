using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    using System;

    public interface IPrintable
    {
        void Print();
    }

    public interface ISerializable
    {
        void SaveToFile(string filePath);
    }

    public class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        // Implement the Print method from IPrintable
        public void Print()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        // Implement the SaveToFile method from ISerializable
        public void SaveToFile(string filePath)
        {
            // For demonstration, we'll just print a message
            Console.WriteLine($"Report saved to file: {filePath}");
        }
    }
}
