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
            Search_Results.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(Search_Results_Item_Selection_Changed);
            Search_Results.Columns.Add("Professor", 150);

            //add columns to my courses list
            My_Courses.View = View.Details;
            My_Courses.Columns.Add("Code");
            My_Courses.Columns.Add("Course Name");
            My_Courses.Columns.Add("Begin Time");
            My_Courses.Columns.Add("End Time");
            My_Courses.Columns.Add("Meets");
            My_Courses.Columns.Add("Building");
            My_Courses.Columns.Add("Room");
            My_Courses.Columns.Add("Open Seats");
            My_Courses.Columns.Add("Professor");
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
            foreach (Course temp in COURSE_LIST)
            {

                if ((temp.longTitle.Contains(input)))
                {
                    search_list.Add(temp);
                }
                else if ((temp.shortTitle.Contains(input)))
                {
                    search_list.Add(temp);
                }
                else if ((temp.courseCode.Contains(input)))
                {
                    search_list.Add(temp);
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
                    if (beginAP.Text == "PM" && staHrs!= 12) //earliest class starts at 8
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
                        if (endAP.Text == "PM" && stoHrs!= 12) //earliest class ends at 8:50
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
                                else if ((beginAP.Text == "AM" && tempbegin >= 12) || (beginAP.Text == "PM" && tempbegin < 12))
                                {
                                    search_list.Remove(tempC);
                                }
                                else if (!(tempC.endTime.Contains(stop)))
                                {
                                    search_list.Remove(tempC);
                                }
                                else if ((endAP.Text == "AM" && tempend >= 12) || (endAP.Text == "PM" && tempend < 12))
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
                                else if ((beginAP.Text == "AM" && tempbegin >= 12) || (beginAP.Text == "PM" && tempbegin < 12))
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
                string tempStr = "";

                if (checkMon.Checked)
                {
                    tempStr += "M";
                }
                if (checkTue.Checked)
                {
                    tempStr += "T";
                }
                if (checkWed.Checked)
                {
                    tempStr += "W";
                }
                if (checkThu.Checked)
                {
                    tempStr += "R";
                }
                if (checkFri.Checked)
                {
                    tempStr += "F";
                }

                foreach (Course tempC in tempList)
                {
                    if (!(tempC.meets.Contains(tempStr)))
                    {
                        search_list.Remove(tempC);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Search_Results_Item_Selection_Changed(object sender, EventArgs e)
        {

        }

        private void box_Click(object sender, EventArgs e) {
            Details.Text = "You clicked a course";
        }

        private void AddCoursesButton_Click(object sender, EventArgs e)
        {
            if(Search_Results.SelectedItems.Count > 0)
            {
                Console.WriteLine(Search_Results.SelectedItems[0]);
            }
        }
    }
}
