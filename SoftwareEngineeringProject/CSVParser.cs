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
            string[] lines = System.IO.File.ReadAllLines("Course List (CSV).csv");
            string[] lines2 = System.IO.File.ReadAllLines("Prereqs List (CSV).csv");
            int lineCount = lines.Length;
            int lineCount2 = lines2.Length;
            Class[] classes = new Class[lineCount];
            for(int i = 0; i < lineCount - 1; ++i)
            {
                string[] tokens = lines[i + 1].Split(',');
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
