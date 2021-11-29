using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLException
{
    public class ArgumentExceptionCourse : Exception
    {
        public override string Message
        {
            get
            {
                return "Ошибка! \nПолю курс было присвоено неправильное значение. Поле курс может принимать только цифры от 1 до 6.";
            }
        }
    }
}
