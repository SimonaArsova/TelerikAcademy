using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class PathStorage
    {

        public static void SavePath()
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\Paths.txt", false))
            {
                foreach (var item in Path.PointsPath)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static string LoadPaths()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Paths.txt"))
            {
                var fileContent = reader.ReadToEnd();
                return fileContent;
            }
        }
    }
}
