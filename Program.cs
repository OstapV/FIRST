using System;
using System.IO;

namespace SIGMA_5_FIRST_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\WebServers\\home\\testsite\\www\\myfile.txt";
            var arr = path.Split("\\");

            string result = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("File name without extension: " + result);

            string root = Path.GetPathRoot(path);
            Console.WriteLine("Path root: " + root);

            int fileIndex = arr.GetUpperBound(0);
            var nameWithoutExt = arr[fileIndex].Split('.');
            Console.WriteLine("Name without extension: " + nameWithoutExt[0]);
            
            Console.WriteLine("Path root: " + arr[0]);

        }
    }
}
