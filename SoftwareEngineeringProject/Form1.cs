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

                if ((course.longTitle.Contains(input)))
                {
                    search_list.Add(course);
                }
                else if ((course.shortTitle.Contains(input)))
                {
                    search_list.Add(course);
                }
                else if ((course.courseCode.Contains(input)))
                {
                    search_list.Add(course);
                }
            } 
            #endregion
            //filter by days if radio button selected
            #region filter_Time
            if (TimeButton.Checked) //will not filter with a given end time only
            {
                Course[] tempList = new Course[search_list.Count];
                search_list.CopyTo(tempList);
                string start = beginTime.Text;
                string stop = endText.Text;
               //filter
                if(start != "")
                {
                    //translate to military time
                    string[] temp = start.Split(':');
                    int staHrs = int.Parse(temp[0]);
                    if (cbBegin.Text == "PM" && staHrs!= 12) //earliest class starts at 8
                    {
                        staHrs += 12;
                        start = staHrs.ToString();
                        for(int i = 1; i <temp.Length; i++)
                        {
                            start += ":" + temp[i];
                        }
                    }
   
                    if(stop != "") //filter by both
                    {
                        //translate to military time
                        string[] tempSt = stop.Split(':');
                        int stoHrs = int.Parse(tempSt[0]);
                        if (cbEnd.Text == "PM" && stoHrs!= 12) //earliest class ends at 8:50
                        {
                            stoHrs += 12;
                            stop = stoHrs.ToString();
                            for (int i = 1; i < temp.Length; i++)
                            {
                                stop += ":" + tempSt[i];
                            }
                        }

                        foreach (Course tempC in tempList)
                        {
                            if (tempC.beginTime == "NULL" || tempC.endTime == "NULL")
                            {
                                search_list.Remove(tempC);

                            }
                            else
                            {

                                string[] courseBeg = tempC.beginTime.Split(':');
                                string[] courseEnd = tempC.endTime.Split(':');
                                int tempbegin = int.Parse(courseBeg[0]);
                                int tempend = int.Parse(courseEnd[0]);


                                if (!(tempC.beginTime.Contains(start)))
                                {
                                    search_list.Remove(tempC);
                                }
                                else if ((cbBegin.Text == "AM" && tempbegin >= 12) || (cbBegin.Text == "PM" && tempbegin < 12))
                                {
                                    search_list.Remove(tempC);
                                }
                                else if (!(tempC.endTime.Contains(stop)))
                                {
                                    search_list.Remove(tempC);
                                }
                                else if ((cbEnd.Text == "AM" && tempend >= 12) || (cbEnd.Text == "PM" && tempend < 12))
                                {
                                    search_list.Remove(tempC);
                                }
                            }
                        }

                    }
                    else //filter by start
                    {
                        foreach(Course tempC in tempList)
                        {
                            if (tempC.beginTime == "NULL" || tempC.endTime == "NULL")
                            {
                                search_list.Remove(tempC);

                            }
                            else
                            {
                                string[] courseBeg = tempC.beginTime.Split(':');
                                int tempbegin = int.Parse(courseBeg[0]);

                                if (!(tempC.beginTime.Contains(start)))
                                {
                                    search_list.Remove(tempC);
                                }
                                else if ((cbBegin.Text == "AM" && tempbegin >= 12) || (cbBegin.Text == "PM" && tempbegin < 12))
                                {
                                    search_list.Remove(tempC);
                                }
                            }
                        }
                    }
                } 
            }
            #endregion

            //filter by time if radio button selected
            #region filter_Days
            else if (DayButton.Checked)
            {
                Course[] tempList = new Course[search_list.Count];
                search_list.CopyTo(tempList);
                List<string> tempStr  = new List<string>();

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

                foreach (Course tempC in tempList)
                {
                    foreach(string tempSS in tempStr)
                    {
                        if(!(tempC.meets.Contains(tempSS)))
                        {
                            search_list.Remove(tempC);
                            break;
                        }
                    }
                }
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

        private void box_Click(object sender, EventArgs e) {
            var tempL = sender as Label;
            string[] course = tempL.Text.Split('\n');

            foreach(Course temp in COURSE_LIST)
            {
                if(temp.courseCode == course[0])
                {
                    string info = temp.courseCode + "\nCourse Name: " + temp.longTitle + "\nMeets on: " + temp.meets + 
                        "\nIn: "  +temp.building + " " + temp.room + "\nTaught by: " + temp.professor + "\nEmpty Seats: "+ (temp.capacity-temp.enrollment).ToString()+"\nStarts at: " + temp.beginTime
                        + "\nEnds at: "+ temp.endTime + "\nPrerequisites:\n";
                    bool prerequs = false;
                    foreach(string preReq in temp.prerequisites)
                    {
                        prerequs = true;
                        info += "\t" + preReq + "\n";
                    }
                    if(!prerequs)
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
            if (Search_Results.SelectedItems.Count > 0)
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

        private void RemoveCourseButton_Click(object sender, EventArgs e)
        {
            if(My_Courses.SelectedItems != null && My_Courses.SelectedItems.Count != 0)
            {
                string tempCC = My_Courses.SelectedItems[0].ToString();
                List<ListViewItem> listremove = new List<ListViewItem>();
                foreach (Course temp in COURSE_LIST)
                {
                    
                    if(tempCC.Contains(temp.courseCode))
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
            if(Details_txt.Text != "")
            {
                string tempCode = Details_txt.Text.Split('\n')[0];
                //find course
                foreach (Course temp in COURSE_LIST)
                {
                    if(tempCode == temp.courseCode)
                    {
                        //remove from schedule
                        Schedule.Instance.RemoveClass(temp);
                        //remove from mycourses
                        List<ListViewItem> removeClasses = new List<ListViewItem>();
                        foreach(ListViewItem tempItm in My_Courses.Items)
                        {
                            if(tempItm.Text == tempCode)
                            {
                                removeClasses.Add(tempItm);
                            }
                        }
                        foreach(ListViewItem tempItm in removeClasses)
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

    }
}
