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

        static class CourseList
        {
            public static Course[] COURSE_LIST = CSVParser.ParseCSV();
        }
        

        public Form1()
        {
            InitializeComponent();

            //add columns to search results list
            Search_Results.Columns.Add("Code", 100);
            Search_Results.Columns.Add("Course Name", 200);
            Search_Results.Columns.Add("Begin Time", 100);
            Search_Results.Columns.Add("End Time", 100);
            Search_Results.Columns.Add("Meets", 100);
            Search_Results.Columns.Add("Building", 100);
            Search_Results.Columns.Add("Room", 100);
            Search_Results.Columns.Add("Open Seats", 100);

            //add columns to my courses list
            My_Courses.Columns.Add("Code");
            My_Courses.Columns.Add("Course Name");
            My_Courses.Columns.Add("Begin Time");
            My_Courses.Columns.Add("End Time");
            My_Courses.Columns.Add("Meets");
            My_Courses.Columns.Add("Building");
            My_Courses.Columns.Add("Room");
            My_Courses.Columns.Add("Open Seats");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string input = SearchBox.Text.ToUpper(); //results will ignore case of search 
            List<Course> search_list = new List<Course>();
            #region genSearch
            foreach (Course temp in CourseList.COURSE_LIST)
            {

                if((temp.longTitle.Contains(input)))
                {
                    search_list.Add(temp);
                }
                else if((temp.shortTitle.Contains(input)))
                {
                    search_list.Add(temp);
                }
                else if((temp.courseCode.Contains(input)))
                {
                    search_list.Add(temp);
                }
            }
            #endregion
            //filter by days if radio button selected
            #region filter_Time
            if (TimeButton.Checked)
            {

            }
            #endregion

            //filter by time if radio button selected
            #region filter_Days
            else if (DayButton.Checked)
            {
                Course[] tempList = new Course[search_list.Count];
                search_list.CopyTo(tempList);
                string tempStr = "";

                if(checkMon.Checked)
                {
                    tempStr += "M";
                }
                if(checkTue.Checked)
                {
                    tempStr += "T";
                }
                if (checkWed.Checked)
                {
                    tempStr += "W";
                }
                if(checkThu.Checked)
                {
                    tempStr += "R";
                }
                if(checkFri.Checked)
                {
                    tempStr += "F";
                }

                foreach(Course tempC in tempList)
                {
                    if(!(tempC.meets.Contains(tempStr)))
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
            foreach(Course temp in search_list)
            {
                string[] arr = new string[8];
                ListViewItem itm;
                arr[0] = temp.courseCode;
                arr[1] = temp.longTitle;
                arr[2] = temp.beginTime;
                arr[3] = temp.endTime;
                arr[4] = temp.meets;
                arr[5] = temp.building;
                arr[6] = temp.room;
                arr[7] = (temp.capacity - temp.enrollment).ToString();
                itm = new ListViewItem(arr);
                Search_Results.Items.Add(itm);
            }
        }

    }
}
