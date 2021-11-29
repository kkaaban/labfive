using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class BaseEntityDAL
    {
        public BaseEntityDAL()
        {
            CreateDateTime = DateTime.Now;
        }
        public DateTime CreateDateTime { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string PassportID { get; set; }
        public uint CountDance { get; set; }
    }
}
