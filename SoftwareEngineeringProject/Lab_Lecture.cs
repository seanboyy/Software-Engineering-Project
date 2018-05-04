using System;
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
            List<Course> lectureList = new List<Course>();
            //determine if courseCode is a lab time
            if(added_course.longTitle.Contains("LAB"))
            {
                //parse courseCode on " "
                string posLect = added_course.courseCode.department + " " +added_course.courseCode.code.ToString();
                foreach(Course course in COURSE_LIST)
                {
                    string tempCode = course.courseCode.department + " " + course.courseCode.code.ToString() + " " + course.courseCode.section;
                    if(tempCode.Contains(posLect) && !course.longTitle.Contains("LAB"))
                    {
                        if(Schedule.Instance.InSchedule(course))
                        {
                            return new List<Course>();
                        }
                        lectureList.Add(course);
                    }
                    
                }
            }
             
            return lectureList;
        }


        //find corresponding lecture
        public List<Course> Find_Labs(Course added_course, Course[] COURSE_LIST)
        {
            List<Course> labList = new List<Course>();

            //if the added class is not a lab
            if (!(added_course.longTitle.Contains("LAB")))
            {
                //determine if there is a corresponding lab for the class
                string posLab = added_course.courseCode.department + " " + added_course.courseCode.code.ToString();
                foreach(Course course in COURSE_LIST)
                {
                    string tempCode = course.courseCode.department + " " + course.courseCode.code.ToString() + " " + course.courseCode.section;
                    if(tempCode.Contains(posLab) && course.longTitle.Contains("LAB"))
                    {
                        if (Schedule.Instance.InSchedule(course))
                        {
                            return new List<Course>();
                        }
                        labList.Add(course);
                    }
                }
            }
            return labList;
        }
    }
}
