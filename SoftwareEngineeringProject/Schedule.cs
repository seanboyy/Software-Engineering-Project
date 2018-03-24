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
                if(Instance == null)
                {
                    instance = new Schedule();
                }
                return instance;
            }
        }

        public void AddClass(Course _class)
        {
            classes.Add(_class);
        }

        public void RemoveClass(Course _class)
        {

        }
    }
}
