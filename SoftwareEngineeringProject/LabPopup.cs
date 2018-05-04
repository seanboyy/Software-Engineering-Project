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
    public partial class LabPopup : Form
    {
        public LabPopup(List<Course> suggested_list)
        {
            InitializeComponent();
            
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
        
        private void Add_Different_Click(object sender, EventArgs e)
        {
            if (SuggestedCoursesList.SelectedItems.Count != 0)
            {
                foreach (Course temp in Form1.Instance.COURSE_LIST)
                {
                    string tempCode = temp.courseCode.department + " " + temp.courseCode.code.ToString() + " " + temp.courseCode.section;
                    if (SuggestedCoursesList.SelectedItems[0].ToString().Contains(tempCode))
                    {
                        //add selected course to Schedule listview
                        Schedule.Instance.AddClass(temp, Form1.Instance.COURSE_LIST);
                        //turn course visible to true (will appear on calendar
                        if (temp.courseBoxes != null)
                        {
                            //turn course visible to true (will appear on calendar
                            if (temp.courseBoxes != null)
                            {
                                foreach (Label tempLabel in temp.courseBoxes)
                                {
                                    tempLabel.Visible = true;
                                    tempLabel.Enabled = true;
                                }
                            }
                            //add temp to my_courses list view
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
                            Form1.Instance.My_Courses.Items.Add(itm);
                        }
                    }
                }
            }
        }
    }
}
