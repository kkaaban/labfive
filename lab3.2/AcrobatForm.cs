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
    public partial class AcrobatForm : Form
    {
        public AcrobatForm()
        {
            InitializeComponent();
        }
        AcrobatEntity acrobat = null;
        public AcrobatEntity Acrobat
        {
            get
            {
                return acrobat;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var acrobat2 = new AcrobatEntity();
            acrobat2.FirsName = textBoxFirstName.Text;
            acrobat2.LastName = textBoxLastName.Text;
            acrobat2.PassportID = textBoxPassID.Text;
            acrobat2.TypeOfAcrobatics = textBoxType.Text;
            acrobat = acrobat2;
            this.Close();
        }

        private void AcrobatForm_Load(object sender, EventArgs e)
        {
            acrobat = null;
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
