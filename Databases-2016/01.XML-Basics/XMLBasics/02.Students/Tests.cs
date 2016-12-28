using System;
using System.Xml;

namespace _02.Students
{
    public class Tests
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../students.xml");
            Console.WriteLine("Loaded XML document:");
            Console.WriteLine(doc.OuterXml);
            Console.WriteLine();

            XmlNode rootNode = doc.DocumentElement;
            Console.WriteLine("Root node: {0}", rootNode.Name);

            foreach (XmlAttribute atr in rootNode.Attributes)
            {
                Console.WriteLine("Attribute: {0}={1}",
                    atr.Name, atr.Value);
            }
            Console.WriteLine();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                Console.WriteLine("Student = {0}",
                    node["name"].InnerText);
                Console.WriteLine("Sex = {0}",
                    node["sex"].InnerText);
                Console.WriteLine("Birth date = {0}",
                    node["birthDate"].InnerText);
                Console.WriteLine();
            }
        }
    }
}
