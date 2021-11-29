using Entity;
using EntityBLLService;
using Mapper;

namespace lab3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonNewInNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json файлы(*.json) | *.json";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveFileDialog.FileName;
            StudentForm formStudent = new StudentForm();
            while (true)
            {
                formStudent.ShowDialog();
                if (formStudent.Student == null)
                {
                    return;
                }
                StudentEntity student = formStudent.Student;
                try
                {
                    StudentBLLService service = new StudentBLLService(path);
                    service.Create(student.StudentPLtoBLL());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.InnerException);
                    continue;
                }
                break;
            }
        }
        private void Output()
        {
            try
            {
                if (path == null)
                    return;
                List<StudentEntity> list = new List<StudentEntity>();
                StudentBLLService service = new StudentBLLService(path);
                list = service.GetList().StudentListBLLtoPL();
                string info = "Студентов: " + list.Count + "\n";
                int id = 0;
                foreach (var student in list)
                {
                    info += "ID: " + id++ + "\n";
                    info += student.ToString() + "\n";
                }
                info += "Процент студентов 1-го курса не из Киева: "
                    + service.Percent1CourseOtherCity() + "%";
                labelOutputData.Text = info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Выберите файл");
                return;
            }
            StudentForm formStudent = new StudentForm();
            while (true)
            {
                formStudent.ShowDialog();
                if (formStudent.Student == null)
                    return;
                StudentEntity student = formStudent.Student;
                try
                {
                    StudentBLLService service = new StudentBLLService(path);
                    service.Add(student.StudentPLtoBLL());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.InnerException);
                    continue;
                }
                break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (path==null)
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
            StudentBLLService service = new StudentBLLService(path);
            try
            {
                service.DeleteById(id);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Ошибка!\nВведённый ID отсутствует в списке");
            }
            catch(Exception exx)
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
            StudentForm formStudent = new StudentForm();
            while (true)
            {
                formStudent.ShowDialog();
                if (formStudent.Student == null)
                    return;
                StudentEntity student = formStudent.Student;
                try
                {
                    StudentBLLService service = new StudentBLLService(path);
                    service.UpdateById(student.StudentPLtoBLL(), id);
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
            StudentBLLService service = new StudentBLLService(path);
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

        private void linkLabelOpenAcrobat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Acrobat acrobat = new Acrobat();
            acrobat.Show();
        }
        private void linkLabelOpenTaxiDriver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaxiDriver taxiDriver = new TaxiDriver();
            taxiDriver.Show();
        }
    }
}