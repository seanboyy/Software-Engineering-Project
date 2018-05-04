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
            var courses = LL.Find_Labs(null, Form1.Instance.COURSE_LIST);
            for(int i = 0; i < courses.Count; ++i)
            {

            }
        }
    }
}
