using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StudentEntity : BaseEntity
    {
        public int DormitoryNumber { get; set; }
        public string Course { get; set; }
        public string StudentID { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return "Имя: " + FirsName + "\n" +
                "Фамилия: " + LastName + "\n" +
                "Паспорт: " + PassportID + "\n" +
                "Курс: " + Course + "\n" +
                "Номер студенческого: " + StudentID + "\n" +
                "Город прибытия: " + City + "\n"+
                "Номер общежития: "+ DormitoryNumber+"\n"+
                "Разряд танцев: " +DanceCategory+"\n";
        }
    }
}
