using System;
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
                if (instance == null)
                {
                    instance = new Schedule();
                }
                return instance;
            }
        }

        public void AddClass(Course course, Course[] COURSE_LIST)
        {
            foreach (Course _course in classes)
            {
                if (course.beginTime == _course.beginTime && (course.meets.Contains(_course.meets) || _course.meets.Contains(course.meets)))
                {
                    string tempCode1 = _course.courseCode.department + " " + _course.courseCode.code.ToString() + " " + _course.courseCode.section;
                    string tempCode2 = course.courseCode.department + " " + course.courseCode.code.ToString() + " " + course.courseCode.section;
                    List<Course> suggestions = new List<Course>();
                    foreach(Course temp in COURSE_LIST)
                    {
                        if(temp.longTitle == course.longTitle && temp.courseCode.section != course.courseCode.section)
                        {
                            suggestions.Add(temp);
                        }
                    }
                    ConflictPopup popup = new ConflictPopup(_course.longTitle, course.longTitle, tempCode1, tempCode2, suggestions);
                    popup.Show();
                    return;
                }
            }
            Lab_Lecture check = new Lab_Lecture();
            List<Course> labList = check.Find_Labs(course, COURSE_LIST);
            List<Course> lectureList = check.Find_Lectures(course, COURSE_LIST);
            bool inSchedule = false;
            if (labList.Any())
            {
                foreach (Course _course in labList)
                {
                    if (course.longTitle == _course.longTitle)
                    {
                        inSchedule = true;
                    }
                }
                if (!inSchedule)
                {
                    LabPopup popLab = new LabPopup(labList);
                    popLab.Show();
                }
            }
            if (lectureList.Any())
            {
                foreach (Course _course in lectureList)
                {
                    if (course.longTitle == _course.longTitle)
                    {
                        inSchedule = true;
                    }
                }
                if (!inSchedule)
                {
                    LabPopup popLab = new LabPopup(lectureList);
                    popLab.Show();
                }
            }
            classes.Add(course);
        }

        public void RemoveClass(Course course)
        {
            classes.RemoveAll(i => (i.courseCode.code == course.courseCode.code && i.courseCode.department == course.courseCode.department && i.courseCode.section == course.courseCode.section));
        }
    }
}
