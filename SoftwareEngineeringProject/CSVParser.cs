using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace SoftwareEngineeringProject
{
    class CSVParser
    {
        public static Course[] ParseCSV()
        {
            
            //grab each line separately from both files
            string[] lines = System.IO.File.ReadAllLines("courses.txt");
            string[] lines2 = System.IO.File.ReadAllLines("prereqs.txt");
            //get the length of each one
            int lineCount = lines.Length;
            int lineCount2 = lines2.Length;
            
            //create a list of classes
            Course[] classes = new Course[lineCount - 1];
            //add classes to the list of classes
            for(int i = 0; i < lineCount - 1; ++i)
            {
                //split the line based on \t
                string[] tokens = lines[i + 1].Split('\t');
                //use the constructor to build a course out of each line
                classes[i] = new Course(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], int.Parse(tokens[8]), int.Parse(tokens[9]), tokens[10], int.Parse(tokens[11]));
            }

            //start grabbing prerequisites
            for(int i = 0; i < lineCount2 - 1; ++i)
            {
                //split the line based on \t
                string[] tokens = lines2[i + 1].Split('\t');
                //seach through the list of classes
                string[] tempArr = tokens[0].Split(' ');
                string tempStr = tempArr[0] + ' ' + tempArr[1];
                for (int j = 0; j < classes.Length; ++j)
                {
                    //to find the class associated with the course code
                    if (classes[j].courseCode.department == tempStr.Split()[0] && classes[j].courseCode.code == int.Parse(tempStr.Split()[1]))
                    {
                        //add course code to prereq list
                        classes[j].prerequisites.Add(tokens[1]);
                    }
                }
            }
            return classes;
        }
    }
}
