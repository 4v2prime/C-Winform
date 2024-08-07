namespace GSTERPExternalExam
{
    partial class frmAddResult
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblExamName = new System.Windows.Forms.Label();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtObtainedMarks = new System.Windows.Forms.TextBox();
            this.rdbbtnPresent = new System.Windows.Forms.RadioButton();
            this.rdbbtnAbsent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFCourse = new System.Windows.Forms.Label();
            this.lblFStudentName = new System.Windows.Forms.Label();
            this.lblFExamname = new System.Windows.Forms.Label();
            this.lblFExamDate = new System.Windows.Forms.Label();
            this.lblFTotalmarks = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.37238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.62762F));
            this.tableLayoutPanel1.Controls.Add(this.lblCourse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblExamName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblExamDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAttendance, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblObtainedMarks, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtObtainedMarks, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFCourse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFStudentName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFExamname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFExamDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFTotalmarks, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalMarks, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Result :";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(3, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(130, 22);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course Name :";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(3, 48);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(134, 22);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student Name :";
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.Location = new System.Drawing.Point(3, 96);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(117, 22);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "Exam Name :";
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamDate.Location = new System.Drawing.Point(3, 144);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(108, 22);
            this.lblExamDate.TabIndex = 0;
            this.lblExamDate.Text = "Exam Date :";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendance.Location = new System.Drawing.Point(3, 192);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(111, 22);
            this.lblAttendance.TabIndex = 0;
            this.lblAttendance.Text = "Attendance :";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarks.Location = new System.Drawing.Point(3, 240);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(114, 22);
            this.lblTotalMarks.TabIndex = 0;
            this.lblTotalMarks.Text = "Total Marks :";
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObtainedMarks.Location = new System.Drawing.Point(3, 288);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(146, 22);
            this.lblObtainedMarks.TabIndex = 0;
            this.lblObtainedMarks.Text = "Obtained Marks :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtObtainedMarks
            // 
            this.txtObtainedMarks.Location = new System.Drawing.Point(239, 291);
            this.txtObtainedMarks.Name = "txtObtainedMarks";
            this.txtObtainedMarks.Size = new System.Drawing.Size(156, 22);
            this.txtObtainedMarks.TabIndex = 2;
            // 
            // rdbbtnPresent
            // 
            this.rdbbtnPresent.AutoSize = true;
            this.rdbbtnPresent.Location = new System.Drawing.Point(3, 3);
            this.rdbbtnPresent.Name = "rdbbtnPresent";
            this.rdbbtnPresent.Size = new System.Drawing.Size(70, 20);
            this.rdbbtnPresent.TabIndex = 3;
            this.rdbbtnPresent.TabStop = true;
            this.rdbbtnPresent.Text = "Pesent";
            this.rdbbtnPresent.UseVisualStyleBackColor = true;
            // 
            // rdbbtnAbsent
            // 
            this.rdbbtnAbsent.AutoSize = true;
            this.rdbbtnAbsent.Location = new System.Drawing.Point(107, 3);
            this.rdbbtnAbsent.Name = "rdbbtnAbsent";
            this.rdbbtnAbsent.Size = new System.Drawing.Size(70, 20);
            this.rdbbtnAbsent.TabIndex = 2;
            this.rdbbtnAbsent.TabStop = true;
            this.rdbbtnAbsent.Text = "Absent";
            this.rdbbtnAbsent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbbtnAbsent);
            this.panel1.Controls.Add(this.rdbbtnPresent);
            this.panel1.Location = new System.Drawing.Point(239, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 42);
            this.panel1.TabIndex = 3;
            // 
            // lblFCourse
            // 
            this.lblFCourse.AutoSize = true;
            this.lblFCourse.Location = new System.Drawing.Point(239, 0);
            this.lblFCourse.Name = "lblFCourse";
            this.lblFCourse.Size = new System.Drawing.Size(44, 16);
            this.lblFCourse.TabIndex = 4;
            this.lblFCourse.Text = "label8";
            // 
            // lblFStudentName
            // 
            this.lblFStudentName.AutoSize = true;
            this.lblFStudentName.Location = new System.Drawing.Point(239, 48);
            this.lblFStudentName.Name = "lblFStudentName";
            this.lblFStudentName.Size = new System.Drawing.Size(44, 16);
            this.lblFStudentName.TabIndex = 4;
            this.lblFStudentName.Text = "label8";
            // 
            // lblFExamname
            // 
            this.lblFExamname.AutoSize = true;
            this.lblFExamname.Location = new System.Drawing.Point(239, 96);
            this.lblFExamname.Name = "lblFExamname";
            this.lblFExamname.Size = new System.Drawing.Size(44, 16);
            this.lblFExamname.TabIndex = 4;
            this.lblFExamname.Text = "label8";
            // 
            // lblFExamDate
            // 
            this.lblFExamDate.AutoSize = true;
            this.lblFExamDate.Location = new System.Drawing.Point(239, 144);
            this.lblFExamDate.Name = "lblFExamDate";
            this.lblFExamDate.Size = new System.Drawing.Size(44, 16);
            this.lblFExamDate.TabIndex = 4;
            this.lblFExamDate.Text = "label8";
            // 
            // lblFTotalmarks
            // 
            this.lblFTotalmarks.AutoSize = true;
            this.lblFTotalmarks.Location = new System.Drawing.Point(239, 240);
            this.lblFTotalmarks.Name = "lblFTotalmarks";
            this.lblFTotalmarks.Size = new System.Drawing.Size(44, 16);
            this.lblFTotalmarks.TabIndex = 4;
            this.lblFTotalmarks.Text = "label8";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(239, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAddResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddResult";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtObtainedMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbbtnAbsent;
        private System.Windows.Forms.RadioButton rdbbtnPresent;
        private System.Windows.Forms.Label lblFCourse;
        private System.Windows.Forms.Label lblFStudentName;
        private System.Windows.Forms.Label lblFExamname;
        private System.Windows.Forms.Label lblFExamDate;
        private System.Windows.Forms.Label lblFTotalmarks;
        private System.Windows.Forms.Button btnCancel;
    }
}