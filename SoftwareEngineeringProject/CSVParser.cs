using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    class CSVParser
    {
        public static Course[] ParseCSV()
        {
            //grab each line separately from both files
            string[] lines = System.IO.File.ReadAllLines("Course List (CSV).csv");
            string[] lines2 = System.IO.File.ReadAllLines("Prereqs List (CSV).csv");
            //get the length of each one
            int lineCount = lines.Length;
            int lineCount2 = lines2.Length;
            //create a list of classes
            Course[] classes = new Course[lineCount];
            //add classes to the list of classes
            for(int i = 0; i < lineCount - 1; ++i)
            {
                //split the line based on ,
                string[] tokens = lines[i + 1].Split(',');
                //use the constructor
                classes[i] = new Course(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], Convert.ToInt32(tokens[8]), Convert.ToInt32(tokens[9]));
            }
            //start grabbing prerequisites
            for(int i = 0; i < lineCount2 - 1; ++i)
            {
                //split the line based on ,
                string[] tokens = lines2[i + 1].Split(',');
                //seach through the list of classes
                for(int j = 0; j < classes.Length; ++j)
                {
                    //to find the class associated with the course code
                    if(classes[j].courseCode == tokens[0])
                    {
                        //searhc through the list of classes
                        for(int k = 0; k < classes.Length; ++k)
                        {
                            //to find the class associated with the prerequisite's course code
                            if(classes[k].courseCode == tokens[1])
                            {
                                //add the class to the list of classes
                                classes[j].prerequisites.Add(classes[k]);
                            }
                        }
                    }
                }
            }
            return classes;
        }
    }
}
