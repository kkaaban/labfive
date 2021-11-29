using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLException
{
    public class ArgumentExceptionPassID : Exception
    {
        public override string Message
        {
            get
            {
                return "Ошибка! \nВведите серию и номер паспорта (например: AA123456) или номер (например: 123456789).";
            }
        }
    }
}
