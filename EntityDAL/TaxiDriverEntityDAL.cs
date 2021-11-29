using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class TaxiDriverEntityDAL : BaseEntityDAL
    {
        public string LicenseID { get; set; }
        public string CarModel { get; set; }
    }
}
