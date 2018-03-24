namespace SoftwareEngineeringProject
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MyClasses = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.RichTextBox();

            this.SearchResults = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SearchLabel = new System.Windows.Forms.TextBox();
            this.DayButton = new System.Windows.Forms.RadioButton();
            this.PopularCourseButton = new System.Windows.Forms.RadioButton();
            this.TimeButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Details = new System.Windows.Forms.ListBox();
            this.WeekCalendar = new System.Windows.Forms.DataGridView();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.SearchHelp = new System.Windows.Forms.ToolTip(this.components);

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
            this.tableLayoutPanel1.Controls.Add(this.MyClasses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MyClasses
            // 
            this.MyClasses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MyClasses.FormattingEnabled = true;
            this.MyClasses.Location = new System.Drawing.Point(3, 221);
            this.MyClasses.Name = "MyClasses";
            this.MyClasses.Size = new System.Drawing.Size(844, 199);
            this.MyClasses.TabIndex = 2;
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
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Controls.Add(this.SearchResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 199);
            this.panel2.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(336, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 51);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // SearchBox

            this.Search.Click += new System.EventHandler(this.Search_Click);
            
            this.SearchBox.Location = new System.Drawing.Point(4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(407, 51);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.Text = "";
            // 
            // SearchResults
            // 
            this.SearchResults.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SearchResults.FormattingEnabled = true;
            this.SearchResults.Location = new System.Drawing.Point(3, 62);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(408, 134);
            this.SearchResults.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox1);
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
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(125, 45);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(67, 17);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "Tuesday";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(195, 45);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 17);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Wednesday";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(279, 45);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Thursday";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(349, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Friday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Monday";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.DayButton.Location = new System.Drawing.Point(4, 43);
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
            this.PopularCourseButton.Location = new System.Drawing.Point(4, 66);
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
            this.TimeButton.Location = new System.Drawing.Point(4, 20);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(48, 17);
            this.TimeButton.TabIndex = 0;
            this.TimeButton.TabStop = true;
            this.TimeButton.Text = "Time";
            this.TimeButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Details);
            this.tabPage2.Controls.Add(this.WeekCalendar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calendar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.Details.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Details.FormattingEnabled = true;
            this.Details.Location = new System.Drawing.Point(102, 319);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(703, 95);
            this.Details.TabIndex = 2;
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
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.WeekCalendar.Location = new System.Drawing.Point(102, 13);
            this.WeekCalendar.Name = "WeekCalendar";
            this.WeekCalendar.RowHeadersVisible = false;
            this.WeekCalendar.Size = new System.Drawing.Size(703, 300);
            this.WeekCalendar.TabIndex = 0;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Monday";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Tuesday";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Wednesday";
            this.Thursday.Name = "Thursday";
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.HeaderText = "Thursday";
            this.Monday.Name = "Monday";
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.Name = "Saturday";
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.Name = "Sunday";
            // 
            // SearchHelp
            // 
            this.SearchHelp.ForeColor = System.Drawing.Color.Ivory;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 455);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton DayButton;
        private System.Windows.Forms.RadioButton PopularCourseButton;
        private System.Windows.Forms.RadioButton TimeButton;
        private System.Windows.Forms.ListBox SearchResults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox SearchBox;
        private System.Windows.Forms.DataGridView WeekCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.ListBox Details;
        private System.Windows.Forms.ListBox MyClasses;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ToolTip SearchHelp;
    }
}

