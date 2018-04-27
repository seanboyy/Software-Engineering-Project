﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    class Schedule
    {
        private static Schedule instance;
        public List<Course> classes;

        private Schedule()
        {
            classes = new List<Course>();
        }
        public static Schedule Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Schedule();
                }
                return instance;
            }
        }

        public void AddClass(Course course)
        {
            classes.Add(course);
        }

        public void RemoveClass(Course course)
        {
            classes.RemoveAll(i => (i.courseCode.code == course.courseCode.code && i.courseCode.department == course.courseCode.department && i.courseCode.section == course.courseCode.section));
        }
    }
}
