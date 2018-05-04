namespace SoftwareEngineeringProject
{
    partial class LabPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuggestedCoursesList = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_Different = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have added a lab or lecture that includes a lab";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Add_Different);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.SuggestedCoursesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 316);
            this.panel3.TabIndex = 1;
            // 
            // SuggestedCoursesList
            // 
            this.SuggestedCoursesList.FullRowSelect = true;
            this.SuggestedCoursesList.Location = new System.Drawing.Point(-4, 31);
            this.SuggestedCoursesList.Margin = new System.Windows.Forms.Padding(4);
            this.SuggestedCoursesList.Name = "SuggestedCoursesList";
            this.SuggestedCoursesList.Size = new System.Drawing.Size(687, 138);
            this.SuggestedCoursesList.TabIndex = 0;
            this.SuggestedCoursesList.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Would you like to add the corresponding section";
            // 
            // Add_Different
            // 
            this.Add_Different.Location = new System.Drawing.Point(0, 175);
            this.Add_Different.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Different.Name = "Add_Different";
            this.Add_Different.Size = new System.Drawing.Size(107, 28);
            this.Add_Different.TabIndex = 4;
            this.Add_Different.Text = "Add";
            this.Add_Different.UseVisualStyleBackColor = true;
            this.Add_Different.Click += new System.EventHandler(this.Add_Different_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.01928F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.98071F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 363);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LabPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LabPopup";
            this.Text = "LabPopup";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Add_Different;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView SuggestedCoursesList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}