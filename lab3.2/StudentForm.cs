using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3._2
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        StudentEntity student = null;
        public StudentEntity Student
        {
            get
            {
                return student;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentEntity student2 = new StudentEntity();
            student2.FirsName = textBoxFirstName.Text;
            student2.LastName = textBoxLastName.Text;
            student2.PassportID = textBoxPassID.Text;
            student2.Course = textBoxCourse.Text;
            student2.StudentID = textBoxStudentID.Text;
            student2.City = textBoxCity.Text;
            student = student2;
            this.Close();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            student = null;
        }
    }
}
