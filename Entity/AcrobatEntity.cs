using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AcrobatEntity : BaseEntity
    {
        public string TypeOfAcrobatics { get; set; }
        public override string ToString()
        {
            return "Имя: " + FirsName + "\n" +
                "Фамилия: " + LastName + "\n" +
                "Паспорт: " + PassportID + "\n" +
                "Разряд танцев: " + DanceCategory + "\n"+
                "Тип акробатики: "+TypeOfAcrobatics+"\n";
        }
    }
}
