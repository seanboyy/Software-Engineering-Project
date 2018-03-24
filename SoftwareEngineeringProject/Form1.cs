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
           
            foreach (Course temp in CourseList.COURSE_LIST)
            {
                if((temp.longTitle.Contains(input)))
                {

                }
            }

        }
    }
}
