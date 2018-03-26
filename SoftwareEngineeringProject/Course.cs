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
        public List<string> prerequisites;
        public int enrollment;
        public int capacity;
        public string professor;
        public float yPos;
        public float[] xPos;
        public float height;
        public List<System.Windows.Forms.Label> courseBoxes;
        public Course(string code, string shortTitle, string longTitle, string begin, string end, string days, string building, string room, int enroll, int capacity, string prof)
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
            prerequisites = new List<string>();
            professor = prof;
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
                float hourpos = hour / 13.5F;
                yPos = hourpos * (size.Height - 10);
                yPos += 10;
                //yPos = UpToNearest10(yPos);
                string[] tokens2 = endTime.Split(':');
                hour = float.Parse(tokens2[0]);
                minute = int.Parse(tokens2[1]);
                temp = minute / 60.0F;
                hour += temp;
                hour -= 8;
                hourpos = hour / 13.5F;
                height = (hourpos * (size.Height));
                height += 10;
                height -= yPos;
                //height = UpToNearest10(yPos);
                xPos = new float[meets.Length];
                courseBoxes = new List<System.Windows.Forms.Label>();
                for (int i = 0; i < meets.Length; ++i)
                {
                    switch (meets[i])
                    {
                        case 'M':
                            xPos[i] = size.Width * (0F / 5);
                            break;
                        case 'T':
                            xPos[i] = size.Width * (1F / 5);
                            break;
                        case 'W':
                            xPos[i] = size.Width * (2F / 5);
                            break;
                        case 'R':
                            xPos[i] = size.Width * (3F / 5);
                            break;
                        case 'F':
                            xPos[i] = size.Width * (4F / 5);
                            break;
                    }
                    courseBoxes.Add(new System.Windows.Forms.Label()
                    {
                        Text = courseCode + "\n" + beginTime + "-" + endTime,
                        AutoSize = false,
                        Size = new System.Drawing.Size(size.Width / 5, (int)height),
                        Visible = false,
                        Enabled = false,
                        Location = new System.Drawing.Point((int)xPos[i], location.Y + (int)yPos),
                        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    });
                    courseBoxes[i].MouseEnter += new EventHandler(box_MouseEnter);
                    courseBoxes[i].MouseLeave += new EventHandler(box_MouseLeave);
                    
                }
            }
        }

        private void box_MouseEnter(object sender, EventArgs e)
        {
            foreach(var label in courseBoxes)
            {
                label.Size += new System.Drawing.Size(0, 20);
                label.BringToFront();
            }
        }

        private void box_MouseLeave(object sender, EventArgs e)
        {
            foreach(var label in courseBoxes)
            {
                label.Size -= new System.Drawing.Size(0, 20);
                label.SendToBack();
            }
        }

       
        private float UpToNearest10(float input)
        {
            return (float)Math.Ceiling(input / 10F) * 10F;
        }
    }
}
