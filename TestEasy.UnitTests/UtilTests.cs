using Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEasy.UnitTests
{
    [TestClass]
    public class UtilTests
    {
        [TestMethod]
        public void ReadFile_File_FileIsRead()
        {
            string filePath = @"C:\Users\Usuario\source\repos\O-PitBlast Tests\Easy\Test01.txt";

            string[] file = Util.readFile(filePath);

            Assert.IsNotNull(file);
        }

        [TestMethod]
        public void ConvertFile_File_FileIsTurnedIntoInt()
        {
            string filePath = @"C:\Users\Usuario\source\repos\O-PitBlast Tests\Easy\Test01.txt";

            string[] file = Util.readFile(filePath);

            int[] fileAsInt = Util.transformIntoInteger(file);

            Assert.AreNotSame(file, fileAsInt);
        }

        [TestMethod]
        public void CreateNewFile_File_FileIsMade()
        {
            string filePath = @"C:\Users\Usuario\source\repos\O-PitBlast Tests\Easy\Test01.txt";

            string[] file = Util.readFile(filePath);

            int[] fileAsInt = Util.transformIntoInteger(file);

            string preparedFile = Util.prepareFileForCreation(fileAsInt);

            if(preparedFile != null && preparedFile.GetType() == "string".GetType())
            {
                Util.createTextFile(preparedFile);
            }

            Assert.IsTrue(preparedFile != null && preparedFile.GetType() == "string".GetType());
        }
    }
}
