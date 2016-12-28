//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

namespace _11.Versioning
{
    using System;
    
    [AttributeUsage(AttributeTargets.Struct
        | AttributeTargets.Class
        | AttributeTargets.Interface
        | AttributeTargets.Method
        | AttributeTargets.Enum
        , AllowMultiple = true)]

    public class VersionAttribute 
        : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; private set; }
        public int Minor { get; private set; }

        public override string ToString()
        {
            return this.Major.ToString() + "." + this.Minor.ToString();
        } 
    }
}
