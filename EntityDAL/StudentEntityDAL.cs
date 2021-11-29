using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class StudentEntityDAL : BaseEntityDAL
    {
        public string Course { get; set; }
        public string StudentID { get; set; }
        public string City { get; set; }
        public int DormitoryNumber { get; set; }
    }
}
