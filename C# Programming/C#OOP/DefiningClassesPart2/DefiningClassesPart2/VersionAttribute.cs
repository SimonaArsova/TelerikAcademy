using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public void getVersion()
        {
            Assembly thisAssem = typeof(Startup).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            Version ver = thisAssemName.Version;

            Console.WriteLine("This is version {0} of {1}.", ver, thisAssemName.Name);
        }
    }
}
