using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    class Class
    {
        public string courseCode;
        public string shortTitle;
        public string longTitle;
        public string beginTime;
        public string endTime;
        public string meets;
        public string building;
        public string room;
        public List<Class> prerequisites;
        public int enrollment;
        public int capacity;

        public Class(string code, string shortTitle, string longTitle, string begin, string end, string days, string building, string room, int enroll, int capacity)
        {
            courseCode = code;
            this.shortTitle = shortTitle;
            this.longTitle = longTitle;
            beginTime = begin;
            endTime = end;
            meets = days;
            this.building = building;
            this.room = room;
            enrollment = enroll;
            this.capacity = capacity;
            prerequisites = new List<Class>();
        }
    }
}
