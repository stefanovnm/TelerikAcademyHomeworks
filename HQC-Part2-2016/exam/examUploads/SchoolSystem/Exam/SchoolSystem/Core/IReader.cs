namespace SchoolSystem.Core
{
    /// <summary>
    /// All readers must have this interface
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Responsible for reading
        /// </summary>
        /// <returns>Returns gathered information as string</returns>
        string ReadLine();
    }
}
