using Entity;
using EntityService;
using Mapper;
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
    public partial class TaxiDriver : Form
    {
        public TaxiDriver()
        {
            InitializeComponent();
        }
        string path;
        private void buttonNewInNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json файлы(*.json) | *.json";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveFileDialog.FileName;
            TaxiDriverForm formTaxiDriver = new TaxiDriverForm();
            while (true)
            {
                formTaxiDriver.ShowDialog();
                if (formTaxiDriver.TaxiDriver == null)
                {
                    return;
                }
                TaxiDriverEntity acrobat = formTaxiDriver.TaxiDriver;
                try
                {
                    TaxiDriverBLLService service = new TaxiDriverBLLService(path);
                    service.Create(acrobat.TaxiDriverPLtoBLL());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.InnerException);
                    continue;
                }
                break;
            }
        }

        private void linkLabelChoiceFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.Cancel)
                return;
            path = file.FileName;
            Output();
        }
        private void Output()
        {
            if (path == null)
                return;
            List<TaxiDriverEntity> list = new List<TaxiDriverEntity>();
            TaxiDriverBLLService service = new TaxiDriverBLLService(path);
            list = service.GetList().TaxiDriverListBLLtoPL();
            string info = "Таксистов: " + list.Count + "\n";
            int id = 0;
            foreach (var acrobat in list)
            {
                info += "ID: " + id++ + "\n";
                info += acrobat.ToString() + "\n";
            }
            labelOutputData.Text = info;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            Output();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            TaxiDriverForm formTaxiDriver = new TaxiDriverForm();
            while (true)
            {
                formTaxiDriver.ShowDialog();
                if (formTaxiDriver.TaxiDriver == null)
                    return;
                TaxiDriverEntity taxiDriver = formTaxiDriver.TaxiDriver;
                try
                {
                    TaxiDriverBLLService service = new TaxiDriverBLLService(path);
                    service.Add(taxiDriver.TaxiDriverPLtoBLL());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }
                break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некорректно введено поле ID");
                return;
            }
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            TaxiDriverBLLService service = new TaxiDriverBLLService(path);
            try
            {
                service.DeleteById(id);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Ошибка!\nВведённый ID отсутствует в списке");
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некорректно введено поле ID");
                return;
            }
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            TaxiDriverForm fromTaxiDriver = new TaxiDriverForm();
            while (true)
            {
                fromTaxiDriver.ShowDialog();
                if (fromTaxiDriver.TaxiDriver == null)
                    return;
                TaxiDriverEntity taxiDriver = fromTaxiDriver.TaxiDriver;
                try
                {
                    TaxiDriverBLLService service = new TaxiDriverBLLService(path);
                    service.UpdateById(taxiDriver.TaxiDriverPLtoBLL(), id);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Ошибка!\nВведённый ID отсутствует в списке");
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                    continue;
                }
                break;
            }
        }

        private void buttonDance_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некорректно введено поле ID");
                return;
            }
            try
            {
                TaxiDriverBLLService service = new TaxiDriverBLLService(path);
                service.Dancing(id);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Ошибка!\nВведённый ID отсутствует в списке");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetLicense_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            int id;
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show("Некорректно введено поле ID");
                return;
            }
            try
            {
                TaxiDriverBLLService service = new TaxiDriverBLLService(path);
                service.SetLicenseID(id);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Ошибка!\nВведённый ID отсутствует в списке");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}