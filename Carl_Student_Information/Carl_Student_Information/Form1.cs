using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Student_Information
{
    public partial class frm_StudentInformation : Form
    {
        public frm_StudentInformation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name: " + txt_FirstName.Text + "\n" +
                "Last Name: " + txt_LastName.Text + "\n" + "Course: " + txt_Course.Text + "\n" + "Year Level: " + txt_YearLevel.Text + "\n" + "School: " + txt_School.Text + "\n" + "Hobby: " + txt_Hobby.Text ,  "Student InformTion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
