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
            /*
            //grab each line separately from both files
            WebClient client = new WebClient();
            Stream readCourses = client.OpenRead("https://github.com/seanboyy/Software-Engineering-Project/blob/master/SoftwareEngineeringProject/courses.txt");
            StreamReader reader = new StreamReader(readCourses);
            List<string> lines = new List<string>();
            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine());
            }
            readCourses.Close();
            Stream readPrereqs = client.OpenRead("https://github.com/seanboyy/Software-Engineering-Project/blob/master/SoftwareEngineeringProject/prereqs.txt");
            reader = new StreamReader(readPrereqs);
            List<string> lines2 = new List<string>();
            while (!reader.EndOfStream)
            {
                lines2.Add(reader.ReadLine());
            }
            //get the length of each one
            int lineCount = lines.ToArray().Length;
            int lineCount2 = lines2.ToArray().Length;
            */
            //grab each line separately from both files
            string[] lines = System.IO.File.ReadAllLines("courses.txt");
            string[] lines2 = System.IO.File.ReadAllLines("prereqs.txt");
            //get the length of each one
            int lineCount = lines.Length;
            int lineCount2 = lines2.Length;
            //create a list of classes
            //create a list of classes
            Course[] classes = new Course[lineCount - 1];
            //add classes to the list of classes
            for(int i = 0; i < lineCount - 1; ++i)
            {
                //split the line based on \t
                string[] tokens = lines[i + 1].Split('\t');
                //use the constructor
                classes[i] = new Course(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], int.Parse(tokens[8]), int.Parse(tokens[9]));
            }
            //start grabbing prerequisites
            for(int i = 0; i < lineCount2 - 1; ++i)
            {
                //split the line based on \t
                string[] tokens = lines2[i + 1].Split('\t');
                //seach through the list of classes
                for(int j = 0; j < classes.Length; ++j)
                {
                    //to find the class associated with the course code
                    if(classes[j].courseCode.Contains(tokens[0]))
                    {
                        //search through the list of classes
                        for(int k = 0; k < classes.Length; ++k)
                        {
                            //to find the class associated with the prerequisite's course code
                            if(classes[k].courseCode.Contains(tokens[1]))
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
