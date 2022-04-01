using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Easy
{
    public class Util
    {

        public static string[] readFile()
        {
            Console.Write("Type your file path: ");
            string inputFile = Console.ReadLine();
            string filePath = @inputFile.Trim('"');

            string[] lines = File.ReadAllLines(filePath);
            string[] linesStringArray = lines[0].Split(',');
            
            return linesStringArray;
        }

        public static int[] transformIntoInteger(string[] fileString)
        {
            int[] linesIntArray = Array.ConvertAll(fileString, s => int.Parse(s));
            Array.Sort(linesIntArray);

            return linesIntArray;
        }

        public static string prepareFileForCreation(int[] intVector)
        {
            return string.Join(",", intVector);
        }

        public static void createTextFile(string preparedFile)
        {
            File.WriteAllText(@"C:\Users\Usuario\Downloads\Test01-Done", preparedFile);
        }

        public static void finishProgram()
        {
            Console.WriteLine("The application is finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
