using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Easy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] file = Util.readFile();

                int[] fileAsInt = Util.transformIntoInteger(file);

                string preparedFile = Util.prepareFileForCreation(fileAsInt);

                if (preparedFile != null && preparedFile.GetType() == "string".GetType())
                {
                    Util.createTextFile(preparedFile);
                }

                Util.finishProgram();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong with the application. Make sure you are making the correct input.");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
