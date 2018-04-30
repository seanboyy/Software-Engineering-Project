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
        public ConflictPopup(string name1, string name2)
        {
            InitializeComponent();
            label2.Text = name1;
            label4.Text = name2;
            //add columns to search results list
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
        }
    }
}
