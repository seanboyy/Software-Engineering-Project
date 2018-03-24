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
        }
    }
}
