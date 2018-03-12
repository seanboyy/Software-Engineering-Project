using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    class CSVParser
    {
        public static Class[] ParseCSV()
        {
            //grab each line separately from both files
            string[] lines = System.IO.File.ReadAllLines("Course List (CSV).csv");
            string[] lines2 = System.IO.File.ReadAllLines("Prereqs List (CSV).csv");
            //get the length of each one
            int lineCount = lines.Length;
            int lineCount2 = lines2.Length;
            //create a list of classes
            Class[] classes = new Class[lineCount];
            //add classes to the list of classes
            for(int i = 0; i < lineCount - 1; ++i)
            {
                //split the line based on the ,
                string[] tokens = lines[i + 1].Split(',');
                //use the constructor
                classes[i] = new Class(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], Convert.ToInt32(tokens[8]), Convert.ToInt32(tokens[9]));
            }
            for(int i = 0; i < lineCount2 - 1; ++i)
            {
                string[] tokens = lines2[i + 1].Split(',');
                for(int j = 0; j < classes.Length; ++j)
                {
                    if(classes[j].courseCode == tokens[0])
                    {
                        for(int k = 0; k < classes.Length; ++k)
                        {
                            if(classes[k].courseCode == tokens[1])
                            {
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
