namespace SchoolSystem.Core
{
    public class BusinessLogicService
    {
        public void Execute(IReader reader, IWriter writer)
        {
            var engine = new Engine(reader, writer);
            engine.Execute();
        }
    }
}
