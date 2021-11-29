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
    public partial class TaxiDriverForm : Form
    {
        public TaxiDriverForm()
        {
            InitializeComponent();
        }
        TaxiDriverEntity taxiDriver = null;
        public TaxiDriverEntity TaxiDriver
        {
            get
            {
                return taxiDriver;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var taxiDriver2 = new TaxiDriverEntity();
            taxiDriver2.FirsName = textBoxFirstName.Text;
            taxiDriver2.LastName = textBoxLastName.Text;
            taxiDriver2.PassportID = textBoxPassID.Text;
            taxiDriver2.CarModel = textBoxType.Text;
            taxiDriver = taxiDriver2;
            this.Close();
        }

        private void AcrobatForm_Load(object sender, EventArgs e)
        {
            taxiDriver = null;
        }
    }
}
