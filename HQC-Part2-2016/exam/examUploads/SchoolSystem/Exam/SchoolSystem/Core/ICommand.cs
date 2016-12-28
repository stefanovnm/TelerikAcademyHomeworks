using System.Collections.Generic;

namespace SchoolSystem.Core
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
