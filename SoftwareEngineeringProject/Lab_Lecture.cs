﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    public class Lab_Lecture
    {
        //find corresponding lab
        public List<Course> Find_Lectures(Course added_course, Course[] COURSE_LIST)
        {
            List<Course> labList = new List<Course>();
            //determine if courseCode is a lab time
            if(added_course.longTitle.Contains("Laboratory"))
            {
                //parse courseCode on " "
                string[] tempCode = added_course.courseCode.Split(' ');
                if(tempCode.Length >1)
                {
                    string posLect = tempCode[0] + tempCode[1];
                    foreach(Course course in COURSE_LIST)
                    {
                        if (course.courseCode.Contains(posLect))
                        {
                            labList.Add(course);
                        }
                    }
                }
            }
             
            return labList;
        }
        //find corresponding lecture
        public List<Course> Find_Labs(Course added_course, Course[] COURSE_LIST)
        {
            List<Course> lectureList = new List<Course>();

            //determine if there is a corresponding lab for the class


            return lectureList;
        }
    }
}
