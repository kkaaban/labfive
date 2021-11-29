using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TaxiDriverEntity : BaseEntity
    {
        public string CarModel { get; set; }
        public string LicenseID { get; set; }
        public override string ToString()
        {
            return "Имя: " + FirsName + "\n" +
                "Фамилия: " + LastName + "\n" +
                "Паспорт: " + PassportID + "\n" +
                "Разряд танцев: " + DanceCategory + "\n" +
                "Модель авто: " + CarModel + "\n" +
                "Номер ВУ: " + LicenseID +"\n";
        }
    }
}
