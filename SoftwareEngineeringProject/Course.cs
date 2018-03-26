using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject
{
    public class Course
    {
        public string courseCode;
        public string shortTitle;
        public string longTitle;
        public string beginTime;
        public string endTime;
        public string meets;
        public string building;
        public string room;
        public List<Course> prerequisites;
        public int enrollment;
        public int capacity;
        public float xPos;
        public float[] yPos;
        public float height;
        public List<System.Windows.Forms.Label> courseBoxes;
        public Course(string code, string shortTitle, string longTitle, string begin, string end, string days, string building, string room, int enroll, int capacity)
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
            prerequisites = new List<Course>();
            string[] tokens1 = begin.Split(':');
            float hour = float.Parse(tokens1[0]);
            int minute = int.Parse(tokens1[1]);
            float temp = minute / 60.0F;
            hour += temp;
            hour -= 8;
            float hourpos = hour / 13.0F;
            xPos = hourpos * 280;
            xPos += 20;
            string[] tokens2 = end.Split(':');
            hour = float.Parse(tokens2[0]);
            minute = int.Parse(tokens2[1]);
            temp = minute / 60.0F;
            hour += temp;
            hour -= 8;
            hourpos = hour / 13.0F;
            height = hourpos * 280 - xPos;
            yPos = new float[days.Length];
            for (int i = 0; i < days.Length; ++i)
            {
                switch (days[i])
                {
                    case 'M':
                        yPos[i] = 0;
                        break;
                    case 'T':
                        yPos[i] = (1 / 7F) * 703.0F;
                        break;
                    case 'W':
                        yPos[i] = (2 / 7F) * 703.0F;
                        break;
                    case 'R':
                        yPos[i] = (3 / 7F) * 703.0F;
                        break;
                    case 'F':
                        yPos[i] = (4 / 7F) * 703.0F;
                        break;
                }
            }
            courseBoxes = new List<System.Windows.Forms.Label>(days.Length);
            for (int i = 0; i < days.Length; ++i)
            {
                courseBoxes[i] = new System.Windows.Forms.Label()
                {
                    Text = courseCode,
                    AutoSize = false,
                    Size = new System.Drawing.Size((int)height, (int)((1 / 7) * 703)),
                    Visible = false,
                    Location = new System.Drawing.Point((int)xPos, (int)yPos[i]),
                };
            };
        }
    }
}
