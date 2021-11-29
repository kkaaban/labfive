using Entity;
using EntityService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mapper;

namespace lab3._2
{
    public partial class Acrobat : Form
    {
        public Acrobat()
        {
            InitializeComponent();
        }
        string path;
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
            List<AcrobatEntity> list = new List<AcrobatEntity>();
            AcrobatBLLService service = new AcrobatBLLService(path);
            list = service.GetList().AcrobatListBLLtoPL();
            string info = "Акробатов: " + list.Count + "\n";
            int id = 0;
            foreach (var acrobat in list)
            {
                info += "ID: " + id++ + "\n";
                info += acrobat.ToString() + "\n";
            }
            labelOutputData.Text = info;

        }

        private void buttonNewInNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json файлы(*.json) | *.json";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveFileDialog.FileName;
            AcrobatForm formAcrobat = new AcrobatForm();
            while (true)
            {
                formAcrobat.ShowDialog();
                if (formAcrobat.Acrobat == null)
                {
                    return;
                }
                AcrobatEntity acrobat= formAcrobat.Acrobat;
                try
                {
                    AcrobatBLLService service = new AcrobatBLLService(path);
                    service.Create(acrobat.AcrobatPLtoBLL());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.InnerException);
                    continue;
                }
                break;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return; 
            }
            AcrobatForm formAcrobat = new AcrobatForm();
            while (true)
            {
                formAcrobat.ShowDialog();
                if (formAcrobat.Acrobat == null)
                    return;
                AcrobatEntity acrobat = formAcrobat.Acrobat;
                try
                {
                    AcrobatBLLService service = new AcrobatBLLService(path);
                    service.Add(acrobat.AcrobatPLtoBLL());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }
                break;
            }
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
            AcrobatBLLService service = new AcrobatBLLService(path);
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
            AcrobatForm formAcrobat = new AcrobatForm();
            while (true)
            {
                formAcrobat.ShowDialog();
                if (formAcrobat.Acrobat == null)
                    return;
                AcrobatEntity acrobat = formAcrobat.Acrobat;
                try
                {
                    AcrobatBLLService service = new AcrobatBLLService(path);
                    service.UpdateById(acrobat.AcrobatPLtoBLL(), id);
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
            AcrobatBLLService service = new AcrobatBLLService(path);
            try
            {
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
    }
}
