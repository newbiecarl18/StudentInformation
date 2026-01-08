namespace Carl_Student_Information
{
    partial class frm_StudentInformation
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
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_YearLevel = new System.Windows.Forms.Label();
            this.lbl_School = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Course = new System.Windows.Forms.TextBox();
            this.txt_School = new System.Windows.Forms.TextBox();
            this.txt_YearLevel = new System.Windows.Forms.TextBox();
            this.txt_Hobby = new System.Windows.Forms.TextBox();
            this.lbl_Hobby = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(135, 101);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(63, 13);
            this.lbl_FirstName.TabIndex = 0;
            this.lbl_FirstName.Text = "First Name: ";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(134, 128);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(64, 13);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "Last Name: ";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Location = new System.Drawing.Point(150, 167);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(46, 13);
            this.lbl_Course.TabIndex = 2;
            this.lbl_Course.Text = "Course: ";
            // 
            // lbl_YearLevel
            // 
            this.lbl_YearLevel.AutoSize = true;
            this.lbl_YearLevel.Location = new System.Drawing.Point(132, 206);
            this.lbl_YearLevel.Name = "lbl_YearLevel";
            this.lbl_YearLevel.Size = new System.Drawing.Size(64, 13);
            this.lbl_YearLevel.TabIndex = 3;
            this.lbl_YearLevel.Text = "Year Level: ";
            // 
            // lbl_School
            // 
            this.lbl_School.AutoSize = true;
            this.lbl_School.Location = new System.Drawing.Point(152, 241);
            this.lbl_School.Name = "lbl_School";
            this.lbl_School.Size = new System.Drawing.Size(46, 13);
            this.lbl_School.TabIndex = 4;
            this.lbl_School.Text = "School: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(203, 94);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 6;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(203, 125);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 7;
            // 
            // txt_Course
            // 
            this.txt_Course.Location = new System.Drawing.Point(203, 160);
            this.txt_Course.Name = "txt_Course";
            this.txt_Course.Size = new System.Drawing.Size(100, 20);
            this.txt_Course.TabIndex = 8;
            // 
            // txt_School
            // 
            this.txt_School.Location = new System.Drawing.Point(202, 234);
            this.txt_School.Name = "txt_School";
            this.txt_School.Size = new System.Drawing.Size(100, 20);
            this.txt_School.TabIndex = 9;
            // 
            // txt_YearLevel
            // 
            this.txt_YearLevel.Location = new System.Drawing.Point(203, 199);
            this.txt_YearLevel.Name = "txt_YearLevel";
            this.txt_YearLevel.Size = new System.Drawing.Size(100, 20);
            this.txt_YearLevel.TabIndex = 10;
            // 
            // txt_Hobby
            // 
            this.txt_Hobby.Location = new System.Drawing.Point(202, 271);
            this.txt_Hobby.Name = "txt_Hobby";
            this.txt_Hobby.Size = new System.Drawing.Size(100, 20);
            this.txt_Hobby.TabIndex = 11;
            // 
            // lbl_Hobby
            // 
            this.lbl_Hobby.AutoSize = true;
            this.lbl_Hobby.Location = new System.Drawing.Point(152, 278);
            this.lbl_Hobby.Name = "lbl_Hobby";
            this.lbl_Hobby.Size = new System.Drawing.Size(44, 13);
            this.lbl_Hobby.TabIndex = 12;
            this.lbl_Hobby.Text = "Hobby: ";
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(303, 330);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 13;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // frm_StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.lbl_Hobby);
            this.Controls.Add(this.txt_Hobby);
            this.Controls.Add(this.txt_YearLevel);
            this.Controls.Add(this.txt_School);
            this.Controls.Add(this.txt_Course);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_School);
            this.Controls.Add(this.lbl_YearLevel);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Name = "frm_StudentInformation";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_YearLevel;
        private System.Windows.Forms.Label lbl_School;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Course;
        private System.Windows.Forms.TextBox txt_School;
        private System.Windows.Forms.TextBox txt_YearLevel;
        private System.Windows.Forms.TextBox txt_Hobby;
        private System.Windows.Forms.Label lbl_Hobby;
        private System.Windows.Forms.Button btn_Enter;
    }
}

