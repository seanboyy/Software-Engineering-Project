﻿namespace SoftwareEngineeringProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search_Results = new System.Windows.Forms.ListView();
            this.Search = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCoursesButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.endAP = new System.Windows.Forms.ComboBox();
            this.beginAP = new System.Windows.Forms.ComboBox();
            this.endText = new System.Windows.Forms.RichTextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.beginTime = new System.Windows.Forms.RichTextBox();
            this.checkTue = new System.Windows.Forms.CheckBox();
            this.checkWed = new System.Windows.Forms.CheckBox();
            this.checkThu = new System.Windows.Forms.CheckBox();
            this.checkFri = new System.Windows.Forms.CheckBox();
            this.checkMon = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.TextBox();
            this.DayButton = new System.Windows.Forms.RadioButton();
            this.PopularCourseButton = new System.Windows.Forms.RadioButton();
            this.TimeButton = new System.Windows.Forms.RadioButton();
            this.My_Courses = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WeekCalendar = new System.Windows.Forms.DataGridView();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchHelp = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Details_txt = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeekCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.My_Courses, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.88152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.11848F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(844, 205);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Search_Results);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 199);
            this.panel2.TabIndex = 1;
            // 
            // Search_Results
            // 
            this.Search_Results.HoverSelection = true;
            this.Search_Results.Location = new System.Drawing.Point(4, 34);
            this.Search_Results.Name = "Search_Results";
            this.Search_Results.Size = new System.Drawing.Size(406, 164);
            this.Search_Results.TabIndex = 4;
            this.Search_Results.UseCompatibleStateImageBehavior = false;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(336, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 24);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(4, 4);
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(407, 24);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AddCoursesButton);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.endAP);
            this.panel1.Controls.Add(this.beginAP);
            this.panel1.Controls.Add(this.endText);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.beginTime);
            this.panel1.Controls.Add(this.checkTue);
            this.panel1.Controls.Add(this.checkWed);
            this.panel1.Controls.Add(this.checkThu);
            this.panel1.Controls.Add(this.checkFri);
            this.panel1.Controls.Add(this.checkMon);
            this.panel1.Controls.Add(this.SearchLabel);
            this.panel1.Controls.Add(this.DayButton);
            this.panel1.Controls.Add(this.PopularCourseButton);
            this.panel1.Controls.Add(this.TimeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(424, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 199);
            this.panel1.TabIndex = 0;
            // 
            // AddCoursesButton
            // 
            this.AddCoursesButton.Location = new System.Drawing.Point(31, 152);
            this.AddCoursesButton.Name = "AddCoursesButton";
            this.AddCoursesButton.Size = new System.Drawing.Size(75, 23);
            this.AddCoursesButton.TabIndex = 18;
            this.AddCoursesButton.Text = "Add Course";
            this.AddCoursesButton.UseVisualStyleBackColor = true;
            this.AddCoursesButton.Click += new System.EventHandler(this.AddCoursesButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox2.Location = new System.Drawing.Point(277, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox1.Location = new System.Drawing.Point(132, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // endAP
            // 
            this.endAP.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM"});
            this.endAP.FormattingEnabled = true;
            this.endAP.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.endAP.Location = new System.Drawing.Point(277, 23);
            this.endAP.Name = "endAP";
            this.endAP.Size = new System.Drawing.Size(43, 21);
            this.endAP.TabIndex = 17;
            // 
            // beginAP
            // 
            this.beginAP.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM"});
            this.beginAP.FormattingEnabled = true;
            this.beginAP.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.beginAP.Location = new System.Drawing.Point(132, 23);
            this.beginAP.Name = "beginAP";
            this.beginAP.Size = new System.Drawing.Size(43, 21);
            this.beginAP.TabIndex = 16;
            // 
            // endText
            // 
            this.endText.Location = new System.Drawing.Point(199, 23);
            this.endText.Multiline = false;
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(66, 22);
            this.endText.TabIndex = 15;
            this.endText.Text = "";
            // 
            // to
            // 
            this.to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.to.Location = new System.Drawing.Point(181, 30);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(17, 13);
            this.to.TabIndex = 14;
            this.to.Text = "to";
            this.to.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // beginTime
            // 
            this.beginTime.Location = new System.Drawing.Point(59, 23);
            this.beginTime.Multiline = false;
            this.beginTime.Name = "beginTime";
            this.beginTime.Size = new System.Drawing.Size(66, 22);
            this.beginTime.TabIndex = 13;
            this.beginTime.Text = "";
            // 
            // checkTue
            // 
            this.checkTue.AutoSize = true;
            this.checkTue.Location = new System.Drawing.Point(125, 50);
            this.checkTue.Name = "checkTue";
            this.checkTue.Size = new System.Drawing.Size(67, 17);
            this.checkTue.TabIndex = 12;
            this.checkTue.Text = "Tuesday";
            this.checkTue.UseVisualStyleBackColor = true;
            // 
            // checkWed
            // 
            this.checkWed.AutoSize = true;
            this.checkWed.Location = new System.Drawing.Point(195, 50);
            this.checkWed.Name = "checkWed";
            this.checkWed.Size = new System.Drawing.Size(83, 17);
            this.checkWed.TabIndex = 11;
            this.checkWed.Text = "Wednesday";
            this.checkWed.UseVisualStyleBackColor = true;
            // 
            // checkThu
            // 
            this.checkThu.AutoSize = true;
            this.checkThu.Location = new System.Drawing.Point(279, 50);
            this.checkThu.Name = "checkThu";
            this.checkThu.Size = new System.Drawing.Size(70, 17);
            this.checkThu.TabIndex = 10;
            this.checkThu.Text = "Thursday";
            this.checkThu.UseVisualStyleBackColor = true;
            // 
            // checkFri
            // 
            this.checkFri.AutoSize = true;
            this.checkFri.Location = new System.Drawing.Point(349, 50);
            this.checkFri.Name = "checkFri";
            this.checkFri.Size = new System.Drawing.Size(54, 17);
            this.checkFri.TabIndex = 9;
            this.checkFri.Text = "Friday";
            this.checkFri.UseVisualStyleBackColor = true;
            // 
            // checkMon
            // 
            this.checkMon.AutoSize = true;
            this.checkMon.Location = new System.Drawing.Point(55, 50);
            this.checkMon.Name = "checkMon";
            this.checkMon.Size = new System.Drawing.Size(64, 17);
            this.checkMon.TabIndex = 7;
            this.checkMon.Text = "Monday";
            this.checkMon.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            this.SearchLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchLabel.Location = new System.Drawing.Point(4, 4);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(65, 13);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search By:";
            // 
            // DayButton
            // 
            this.DayButton.AutoSize = true;
            this.DayButton.Location = new System.Drawing.Point(4, 48);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(49, 17);
            this.DayButton.TabIndex = 5;
            this.DayButton.TabStop = true;
            this.DayButton.Text = "Days";
            this.DayButton.UseVisualStyleBackColor = true;
            // 
            // PopularCourseButton
            // 
            this.PopularCourseButton.AutoSize = true;
            this.PopularCourseButton.Location = new System.Drawing.Point(4, 71);
            this.PopularCourseButton.Name = "PopularCourseButton";
            this.PopularCourseButton.Size = new System.Drawing.Size(102, 17);
            this.PopularCourseButton.TabIndex = 4;
            this.PopularCourseButton.TabStop = true;
            this.PopularCourseButton.Text = "Popular Courses";
            this.PopularCourseButton.UseVisualStyleBackColor = true;
            // 
            // TimeButton
            // 
            this.TimeButton.AutoSize = true;
            this.TimeButton.Location = new System.Drawing.Point(4, 25);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(48, 17);
            this.TimeButton.TabIndex = 0;
            this.TimeButton.TabStop = true;
            this.TimeButton.Text = "Time";
            this.TimeButton.UseVisualStyleBackColor = true;
            // 
            // My_Courses
            // 
            this.My_Courses.Location = new System.Drawing.Point(3, 214);
            this.My_Courses.Name = "My_Courses";
            this.My_Courses.Size = new System.Drawing.Size(844, 204);
            this.My_Courses.TabIndex = 1;
            this.My_Courses.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Details_txt);
            this.tabPage2.Controls.Add(this.WeekCalendar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calendar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WeekCalendar
            // 
            this.WeekCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WeekCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Monday,
            this.Friday});
            this.WeekCalendar.Location = new System.Drawing.Point(102, 13);
            this.WeekCalendar.Name = "WeekCalendar";
            this.WeekCalendar.ReadOnly = true;
            this.WeekCalendar.RowHeadersVisible = false;
            this.WeekCalendar.Size = new System.Drawing.Size(703, 300);
            this.WeekCalendar.TabIndex = 0;
            // 
            // Tuesday
            // 
            this.Tuesday.Frozen = true;
            this.Tuesday.HeaderText = "Monday";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Width = 140;
            // 
            // Wednesday
            // 
            this.Wednesday.Frozen = true;
            this.Wednesday.HeaderText = "Tuesday";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Width = 140;
            // 
            // Thursday
            // 
            this.Thursday.Frozen = true;
            this.Thursday.HeaderText = "Wednesday";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Width = 140;
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.Frozen = true;
            this.Monday.HeaderText = "Thursday";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Width = 140;
            // 
            // Friday
            // 
            this.Friday.Frozen = true;
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Width = 140;
            // 
            // SearchHelp
            // 
            this.SearchHelp.ForeColor = System.Drawing.Color.Ivory;
            // 
            // Details_txt
            // 
            this.Details_txt.Location = new System.Drawing.Point(102, 319);
            this.Details_txt.Name = "Details_txt";
            this.Details_txt.Size = new System.Drawing.Size(702, 83);
            this.Details_txt.TabIndex = 1;
            this.Details_txt.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 455);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeekCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchLabel;
        private System.Windows.Forms.CheckBox checkTue;
        private System.Windows.Forms.CheckBox checkWed;
        private System.Windows.Forms.CheckBox checkThu;
        private System.Windows.Forms.CheckBox checkFri;
        private System.Windows.Forms.CheckBox checkMon;
        private System.Windows.Forms.RadioButton DayButton;
        private System.Windows.Forms.RadioButton PopularCourseButton;
        private System.Windows.Forms.RadioButton TimeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox SearchBox;
        private System.Windows.Forms.DataGridView WeekCalendar;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ToolTip SearchHelp;
        private System.Windows.Forms.ListView Search_Results;
        private System.Windows.Forms.ListView My_Courses;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.RichTextBox beginTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox endText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddCoursesButton;
        private System.Windows.Forms.ComboBox endAP;
        private System.Windows.Forms.ComboBox beginAP;
        private System.Windows.Forms.RichTextBox Details_txt;
    }
}

