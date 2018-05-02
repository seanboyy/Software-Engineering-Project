using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringProject
{
    public partial class ConflictPopup : Form
    {
        private string conflictCourse1;
        private string conflictCourse2;
        public ConflictPopup(string name1, string name2, string code1, string code2, List<Course> suggested_list)
        {
            InitializeComponent();
            conflictCourse1 = name1;
            conflictCourse2 = name2;
            label2.Text = code1;
            label3.Text = name1;

            label4.Text = code2;
            label5.Text = name2;

            //add columns to suggested replacements list
            SuggestedCoursesList.View = View.Details;
            SuggestedCoursesList.Columns.Add("Code", 100);
            SuggestedCoursesList.Columns.Add("Course Name", 200);
            SuggestedCoursesList.Columns.Add("Begin Time", 100);
            SuggestedCoursesList.Columns.Add("End Time", 100);
            SuggestedCoursesList.Columns.Add("Meets", 100);
            SuggestedCoursesList.Columns.Add("Building", 100);
            SuggestedCoursesList.Columns.Add("Room", 100);
            SuggestedCoursesList.Columns.Add("Open Seats", 100);
            SuggestedCoursesList.Columns.Add("Professor", 150);

            foreach (Course temp in suggested_list)
            {
                string[] arr = new string[9];
                ListViewItem itm;
                arr[0] = temp.courseCode.department + " " + temp.courseCode.code.ToString() + " " + temp.courseCode.section;

                arr[1] = temp.longTitle;
                arr[2] = temp.beginTime;
                arr[3] = temp.endTime;
                arr[4] = temp.meets;
                arr[5] = temp.building;
                arr[6] = temp.room;
                arr[7] = (temp.capacity - temp.enrollment).ToString();
                arr[8] = temp.professor;
                itm = new ListViewItem(arr);
                SuggestedCoursesList.Items.Add(itm);
            }
        }
    }
}
