using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringProject;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lab_Lecture LL = new Lab_Lecture();
            var courses = LL.Find_Labs(new Course("BIOL 102 A", "GEN BIOL II", "GENERAL BIOLOGY II", "08:00:00", "08:50:00", "MWF", "HAL", "308", 52, 52, "Dudt, Jan F.", 4), CSVParser.ParseCSV());
            for(int i = 0; i < courses.Count; ++i)
            {
                Assert.AreEqual(courses[i].courseCode.department, "BIOL");
            }
        }
    }
}
