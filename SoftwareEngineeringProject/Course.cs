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
        }

        public void box_Click(object sender, EventArgs e)
        {

        }

        public void setBoxes(System.Drawing.Size size, System.Drawing.Point location)
        {
            if (beginTime != "NULL" && endTime != "NULL")
            {
                string[] tokens1 = beginTime.Split(':');
                float hour = float.Parse(tokens1[0]);
                int minute = int.Parse(tokens1[1]);
                float temp = minute / 60.0F;
                hour += temp;
                hour -= 8;
                float hourpos = hour / 13.0F;
                xPos = hourpos * size.Height;
                string[] tokens2 = endTime.Split(':');
                hour = float.Parse(tokens2[0]);
                minute = int.Parse(tokens2[1]);
                temp = minute / 60.0F;
                hour += temp;
                hour -= 8;
                hourpos = hour / 13.0F;
                height = hourpos * size.Height - xPos;
                yPos = new float[meets.Length];
                for (int i = 0; i < meets.Length; ++i)
                {
                    switch (meets[i])
                    {
                        case 'M':
                            yPos[i] = size.Width * (0F / 5);
                            break;
                        case 'T':
                            yPos[i] = size.Width * (1F / 5);
                            break;
                        case 'W':
                            yPos[i] = size.Width * (2F / 5);
                            break;
                        case 'R':
                            yPos[i] = size.Width * (3F / 5);
                            break;
                        case 'F':
                            yPos[i] = size.Width * (4F / 5);
                            break;
                    }
                }
                courseBoxes = new List<System.Windows.Forms.Label>();
                for (int i = 0; i < meets.Length; ++i)
                {
                    courseBoxes.Add(new System.Windows.Forms.Label()
                    {
                        Text = courseCode + "\n" + beginTime + "-" + endTime,
                        AutoSize = false,
                        Size = new System.Drawing.Size(size.Width / 5, (int)height),
                        Visible = true,
                        Location = new System.Drawing.Point((int)yPos[i], location.Y + (int)xPos),
                        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    });
                };
            }
        }
    }
}
