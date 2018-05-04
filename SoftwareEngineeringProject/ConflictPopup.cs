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
    public partial class ConflictPopup : Form1
    {
        private string conflictCourse1;
        private string conflictCourse2;
        private string conflictCourseCode1;
        private string conflictCourseCode2;
        public ConflictPopup(string name1, string name2, string code1, string code2, List<Course> suggested_list)
        {
            InitializeComponent();
            conflictCourse1 = name1;
            conflictCourse2 = name2;
            conflictCourseCode1 = code1;
            conflictCourseCode2 = code2;

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

        private void Class_1_Remove_Click(object sender, EventArgs e)
        {
            List<ListViewItem> listremove = new List<ListViewItem>();
            foreach (Course temp in COURSE_LIST)
            {
                string tempCode = temp.courseCode.department + " " + temp.courseCode.code.ToString() + " " + temp.courseCode.section;
                if (conflictCourseCode1.Contains(tempCode))
                {
                    //remove from Schedule
                    Schedule.Instance.RemoveClass(temp);
                    //remove from mycourses
                    foreach (ListViewItem tempItm in My_Courses.Items)
                    {
                        if (tempItm.Text == tempCode)
                        {
                            listremove.Add(tempItm);
                        }
                    }
                        
                    //remove from calendar view
                    if (temp.courseBoxes != null)
                    {
                        foreach (System.Windows.Forms.Label tempLabel in temp.courseBoxes)
                        {
                            tempLabel.Visible = false;
                            tempLabel.Enabled = false;
                        }
                    }
                }
                foreach(ListViewItem itmTemp in listremove)
                {
                    My_Courses.Items.Remove(itmTemp);
                }
            }
        }

        private void Class_2_Remove_Click(object sender, EventArgs e)
        {
            List<ListViewItem> listremove = new List<ListViewItem>();
            foreach (Course temp in COURSE_LIST)
            {
                string tempCode = temp.courseCode.department + " " + temp.courseCode.code.ToString() + " " + temp.courseCode.section;
                if (conflictCourseCode2.Contains(tempCode))
                {
                    //remove from Schedule
                    Schedule.Instance.RemoveClass(temp);
                    //remove from mycourses
                    foreach (ListViewItem tempItm in My_Courses.Items)
                    {
                        if (tempItm.Text == tempCode)
                        {
                            listremove.Add(tempItm);
                        }
                    }

                    //remove from calendar view
                    if (temp.courseBoxes != null)
                    {
                        foreach (System.Windows.Forms.Label tempLabel in temp.courseBoxes)
                        {
                            tempLabel.Visible = false;
                            tempLabel.Enabled = false;
                        }
                    }
                }
                foreach (ListViewItem itmTemp in listremove)
                {
                    My_Courses.Items.Remove(itmTemp);
                }
            }
        }

        private void Add_Different_Click(object sender, EventArgs e)
        {
            if (SuggestedCoursesList.SelectedItems.Count != 0)
            {
                foreach (Course temp in COURSE_LIST)
                {
                    string tempCode = temp.courseCode.department + " " + temp.courseCode.code.ToString() + " " + temp.courseCode.section;
                    if (SuggestedCoursesList.SelectedItems[0].ToString().Contains(tempCode))
                    {
                        //add selected course to Schedule listview
                        Schedule.Instance.AddClass(temp, COURSE_LIST);
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
                            My_Courses.Items.Add(itm);
                        }
                    }
                }
            }
        }
    }
}
