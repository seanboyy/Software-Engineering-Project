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
            //filter by days if radio button selected
            if(TimeButton.Checked)
            {

            }
            //filter by time if radio button selected
            else if(DayButton.Checked)
            {
                Course[] tempList = new Course[search_list.Count];
                search_list.CopyTo(temp);
                string tempStr = "";

                if()
            }
            /*
             * TODO: filter by popular courses if radio button selected
             */

        }
    }
}
