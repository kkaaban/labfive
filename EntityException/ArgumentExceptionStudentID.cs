using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLException
{
    public class ArgumentExceptionStudentID : Exception
    {
        public override string Message
        {
            get
            {
                return "Ошибка! \nПолю номер студенческого было присвоено неверное значение. Поле номер студенческого может принимать только строку типа: AA12345678.";
            }
        }
    }
}
