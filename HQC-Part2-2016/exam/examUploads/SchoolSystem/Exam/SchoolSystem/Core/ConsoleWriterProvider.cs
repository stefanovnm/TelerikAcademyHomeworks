using System;
using System.Threading;

namespace SchoolSystem.Core
{
    public class ConsoleWriterProvider : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(350);
        }
    }
}
