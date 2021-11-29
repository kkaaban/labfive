using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class BaseEntity
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string PassportID { get; set; }
        public uint CountDance { get; set; }
        public string DanceCategory { get; set; }
    }
}
