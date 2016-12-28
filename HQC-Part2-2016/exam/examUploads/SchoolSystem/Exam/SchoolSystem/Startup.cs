using SchoolSystem.Core;

namespace SchoolSystem
{
    public class Startup
    {
        public static void Main()
        {
            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();

            var service = new BusinessLogicService();
            service.Execute(reader, writer);
        }
    }
}
