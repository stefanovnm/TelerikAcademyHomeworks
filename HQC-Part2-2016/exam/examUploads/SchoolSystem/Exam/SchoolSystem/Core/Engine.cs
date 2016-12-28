using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using SchoolSystem.Models;

namespace SchoolSystem.Core
{
    /// <summary>
    /// Class Engine is responsible for handling the commands
    /// </summary>
    public class Engine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        internal static Dictionary<int, Teacher> Teachers { get; set; } = new Dictionary<int, Teacher>();

        internal static Dictionary<int, Student> Students { get; set; } = new Dictionary<int, Student>();

        /// <summary>
        /// This method gets the command from the reader, check if there is existing class who can handle the command and print it
        /// </summary>
        public void Execute()
        {
            while (true)
            {
                try
                {
                    var consoleCommand = this.reader.ReadLine();
                    if (consoleCommand == "End")
                    {
                        break;
                    }

                    var orderName = consoleCommand.Split(' ')[0];

                    var assembly = this.GetType().GetTypeInfo().Assembly;
                    var commandHandler = assembly.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(classes => classes == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(orderName.ToLower()))
                        .FirstOrDefault();

                    if (commandHandler == null)
                    {
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var order = Activator.CreateInstance(commandHandler) as ICommand;

                    var parameters = consoleCommand.Split(' ').ToList();
                    parameters.RemoveAt(0);
                    this.writer.WriteLine(order.Execute(parameters));
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
