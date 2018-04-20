using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEngineeringProject;


namespace SoftwareEngineeringProject
{
    public partial class Form1 : Form
    {
        public Course[] COURSE_LIST = CSVParser.ParseCSV();

        public Filter filter = new Filter();

        public Form1()
        {
            InitializeComponent();

            //add columns to search results list
            Search_Results.View = View.Details;
            Search_Results.Columns.Add("Code", 100);
            Search_Results.Columns.Add("Course Name", 200);
            Search_Results.Columns.Add("Begin Time", 100);
            Search_Results.Columns.Add("End Time", 100);
            Search_Results.Columns.Add("Meets", 100);
            Search_Results.Columns.Add("Building", 100);
            Search_Results.Columns.Add("Room", 100);
            Search_Results.Columns.Add("Open Seats", 100);
            Search_Results.Columns.Add("Professor", 150);

            //add columns to my courses list
            My_Courses.View = View.Details;
            My_Courses.Columns.Add("Code", 100);
            My_Courses.Columns.Add("Course Name", 200);
            My_Courses.Columns.Add("Begin Time", 100);
            My_Courses.Columns.Add("End Time", 100);
            My_Courses.Columns.Add("Meets", 60);
            My_Courses.Columns.Add("Building", 75);
            My_Courses.Columns.Add("Room", 60);
            My_Courses.Columns.Add("Open Seats", 75);
            My_Courses.Columns.Add("Professor", 150);

            foreach (Course course in COURSE_LIST)
            {
                course.setBoxes(WeekCalendar.Size, WeekCalendar.Location);
                if (course.courseBoxes != null)
                {
                    foreach (Label courseBox in course.courseBoxes)
                    {
                        courseBox.Click += new EventHandler(box_Click);
                        WeekCalendar.Controls.Add(courseBox);
                    }
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search_Results.Items.Clear();
            string input = SearchBox.Text.ToUpper(); //results will ignore case of search 
            List<Course> search_list = new List<Course>();
            #region genSearch
            foreach (Course course in COURSE_LIST)
            {

                if ((course.longTitle.Contains(input)) || (course.shortTitle.Contains(input)) || (course.courseCode.Contains(input)))
                {
                    search_list.Add(course);
                }
            }
            #endregion
            //filter by days if radio button selected
            #region filter_Time
            if (TimeButton.Checked) //will not filter with a given end time only
            {
                string beginStr = beginTime.Text, endStr = endText.Text;
                int beginHr = 0 , beginMin= 0, endHr = 0, endMin = 0;
                //get beginning of range
                if(beginStr != "")
                {
                    string[] temp = beginStr.Split(':');
                    bool isNumeric = int.TryParse(temp[0], out beginHr);
                    if(isNumeric&&(cbBegin.Text == "PM" && beginHr < 12)) //needs translated to military time
                    {
                        beginHr += 12;
                    }
                    if(temp.Length > 1)
                        int.TryParse(temp[1], out beginMin);
           
                }

                //get end of range
                if (endStr != "")
                {
                    string[] temp = endStr.Split(':');
                    bool isNumeric = int.TryParse(temp[0], out endHr);
                    if(isNumeric&&(cbEnd.Text == "PM" && endHr <12)) //needs translated to military time
                    {
                        endHr += 12;
                    }
                    if(temp.Length >1)
                        int.TryParse(temp[1], out endMin);
                }
                search_list = filter.Filter_Time(search_list, beginHr, endHr, beginMin, endMin);
            }
            #endregion

            //filter by time if radio button selected
            #region filter_Days
            else if (DayButton.Checked)
            {
                List<string> tempStr = new List<string>();

                if (checkMon.Checked)
                {
                    tempStr.Add("M");
                }
                if (checkTue.Checked)
                {
                    tempStr.Add("T");
                }
                if (checkWed.Checked)
                {
                    tempStr.Add("W");
                }
                if (checkThu.Checked)
                {
                    tempStr.Add("R");
                }
                if (checkFri.Checked)
                {
                    tempStr.Add("F");
                }

                search_list = filter.Filter_Days(search_list, tempStr);
                
            }
            #endregion
            /*
             * TODO: filter by popular courses if radio button selected
             */

            //get class information from search_list into SearchResults
            foreach (Course temp in search_list)
            {
                string[] arr = new string[9];
                ListViewItem itm;
                arr[0] = temp.courseCode;
                arr[1] = temp.longTitle;
                arr[2] = temp.beginTime;
                arr[3] = temp.endTime;
                arr[4] = temp.meets;
                arr[5] = temp.building;
                arr[6] = temp.room;
                arr[7] = (temp.capacity - temp.enrollment).ToString();
                arr[8] = temp.professor;
                itm = new ListViewItem(arr);
                Search_Results.Items.Add(itm);
            }
        }

        private void box_Click(object sender, EventArgs e)
        {
            var tempL = sender as Label;
            string[] course = tempL.Text.Split('\n');

            foreach (Course temp in COURSE_LIST)
            {
                if (temp.courseCode == course[0])
                {
                    string info = temp.courseCode + "\nCourse Name: " + temp.longTitle + "\nMeets on: " + temp.meets +
                        "\nIn: " + temp.building + " " + temp.room + "\nTaught by: " + temp.professor + "\nEmpty Seats: " + (temp.capacity - temp.enrollment).ToString() + "\nStarts at: " + temp.beginTime
                        + "\nEnds at: " + temp.endTime + "\nPrerequisites:\n";
                    bool prerequs = false;
                    foreach (string preReq in temp.prerequisites)
                    {
                        prerequs = true;
                        info += "\t" + preReq + "\n";
                    }
                    if (!prerequs)
                    {
                        info += "None";
                    }
                    Details_txt.Text = info;
                    break;
                }
            }
        }

        private void AddCoursesButton_Click(object sender, EventArgs e)
        {
            if (Search_Results.SelectedItems.Count != 0)
            {
                foreach (Course temp in COURSE_LIST)
                {
                    if (Search_Results.SelectedItems[0].ToString().Contains(temp.courseCode))
                    {

                        //add selected course to Schedule listview
                        Schedule.Instance.AddClass(temp);
                        //turn course visible to true (will appear on calendar
                        if (temp.courseBoxes != null)
                        {

                            //add selected course to Schedule listview
                            Schedule.Instance.AddClass(temp);
                            //turn course visible to true (will appear on calendar
                            if (temp.courseBoxes != null)
                            {
                                foreach (System.Windows.Forms.Label tempLabel in temp.courseBoxes)
                                {
                                    tempLabel.Visible = true;
                                    tempLabel.Enabled = true;
                                }
                            }
                            //add temp to my_courses list view
                            string[] arr = new string[9];
                            ListViewItem itm;
                            arr[0] = temp.courseCode;
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

        private void RemoveCourseButton_Click(object sender, EventArgs e)
        {
            if (My_Courses.SelectedItems != null && My_Courses.SelectedItems.Count != 0)
            {
                string tempCC = My_Courses.SelectedItems[0].ToString();
                List<ListViewItem> listremove = new List<ListViewItem>();
                foreach (Course temp in COURSE_LIST)
                {

                    if (tempCC.Contains(temp.courseCode))
                    {
                        //remove from Schedule
                        Schedule.Instance.RemoveClass(temp);
                        //remove from mycourses
                        foreach (ListViewItem tempItm in My_Courses.Items)
                        {
                            if (tempItm.Text == temp.courseCode)
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
        }

        private void RemoveCourseButtonCal_Click(object sender, EventArgs e)
        {
            if (Details_txt.Text != "")
            {
                string tempCode = Details_txt.Text.Split('\n')[0];
                //find course
                foreach (Course temp in COURSE_LIST)
                {
                    if (tempCode == temp.courseCode)
                    {
                        //remove from schedule
                        Schedule.Instance.RemoveClass(temp);
                        //remove from mycourses
                        List<ListViewItem> removeClasses = new List<ListViewItem>();
                        foreach (ListViewItem tempItm in My_Courses.Items)
                        {
                            if (tempItm.Text == tempCode)
                            {
                                removeClasses.Add(tempItm);
                            }
                        }
                        foreach (ListViewItem tempItm in removeClasses)
                        {
                            My_Courses.Items.Remove(tempItm);
                        }
                        //remove from calendar
                        if (temp.courseBoxes != null)
                        {
                            foreach (System.Windows.Forms.Label tempLabel in temp.courseBoxes)
                            {
                                tempLabel.Visible = false;
                                tempLabel.Enabled = false;
                            }
                        }
                    }
                }
                Details_txt.Text = "";
            }
        }
        
        private void beginTime_TextChanged(object sender, EventArgs e)
        {
            ClearAllButTime();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllButTime();
        }

        private void endText_TextChanged(object sender, EventArgs e)
        {
            ClearAllButTime();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllButTime();
        }

        private void AllButton_CheckedChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void PopularCourseButton_CheckedChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void DayButton_CheckedChanged(object sender, EventArgs e)
        {
            beginTime.Text = "";
            endText.Text = "";
            cbBegin.ResetText();
            cbEnd.ResetText();
        }

        private void checkMon_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllButDay();
        }

        private void checkTue_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllButDay();
        }

        private void checkWed_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllButDay();
        }

        private void checkThu_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllButDay();
        }

        private void checkFri_CheckedChanged(object sender, EventArgs e)
        {
            ClearAllButDay();
        }

        private void ClearAllButDay()
        {
            PopularCourseButton.Checked = false;
            DayButton.Checked = true;
            TimeButton.Checked = false;
            AllButton.Checked = false;
            beginTime.Text = "";
            endText.Text = "";
            cbBegin.ResetText();
            cbEnd.ResetText();

        }

        private void ClearAll()
        {
            beginTime.Text = "";
            endText.Text = "";
            cbBegin.ResetText();
            cbEnd.ResetText();
            checkMon.Checked = false;
            checkTue.Checked = false;
            checkWed.Checked = false;
            checkThu.Checked = false;
            checkFri.Checked = false;
        }

        private void ClearAllButTime()
        {
            PopularCourseButton.Checked = false;
            DayButton.Checked = false;
            TimeButton.Checked = true;
            AllButton.Checked = false;
            checkMon.Checked = false;
            checkTue.Checked = false;
            checkWed.Checked = false;
            checkThu.Checked = false;
            checkFri.Checked = false;
        }
    }
}
