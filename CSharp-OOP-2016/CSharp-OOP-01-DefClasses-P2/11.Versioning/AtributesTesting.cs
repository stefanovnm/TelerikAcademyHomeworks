namespace _11.Versioning
{
    using System;

    [Version(1,11)]

    public class AtributesTesting
    {
        public static void Test()
        {
            Type type = typeof(AtributesTesting);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("AttributesTesting is version: "+attr.ToString());
                Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.ToString() + " is version: " + attr.ToString());//didn't succeed to get only class name without namespace
            }
        }        
    }
}
