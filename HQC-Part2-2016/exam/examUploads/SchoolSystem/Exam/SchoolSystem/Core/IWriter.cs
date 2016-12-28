namespace SchoolSystem.Core
{
    /// <summary>
    /// All writers must have this interface
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Responsible for printing the message
        /// </summary>
        /// <param name="message">Message to print</param>
        void WriteLine(string message);
    }
}
