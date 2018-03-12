using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    class Schedule
    {
        public List<Class> classes;

        public Schedule() { }

        public void AddClass(Class _class)
        {
            classes.Add(_class);
        }

        public void RemoveClass(Class _class)
        {
            classes.Remove(_class);
        }
    }
}
