using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLException
{
    public class ArgumentExceptionProperNoun : Exception
    {
        public override string Message
        {
            get
            {
                return "Ошибка! \nПоля имя, фамилия, город прибытия могут принимать только кириллицу.";
            }
        }
    }
}
