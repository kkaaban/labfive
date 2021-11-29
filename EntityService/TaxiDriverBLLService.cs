using EntityBLL;
using EntityDALService;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityService
{
    public class TaxiDriverBLLService
    {
        readonly string path;
        public TaxiDriverBLLService(string path)
        {
            this.path = path;
        }
        public void Create(TaxiDriverEntityBLL taxiDriver)
        {
            TaxiDriverDALService service = new TaxiDriverDALService(path);
            service.Create(taxiDriver.TaxiDriverBLLtoDAL());
        }
        public List<TaxiDriverEntityBLL> GetList()
        {
            List<TaxiDriverEntityBLL> list;
            TaxiDriverDALService service = new TaxiDriverDALService(path);
            list = service.GetList().TaxiDriverListDALtoBLL();
            return list;
        }
        public void Add(TaxiDriverEntityBLL taxiDriver)
        {
            TaxiDriverDALService service = new TaxiDriverDALService(path);
            service.Add(taxiDriver.TaxiDriverBLLtoDAL());
        }
        public void DeleteById(int id)
        {
            TaxiDriverDALService service = new TaxiDriverDALService(path);
            service.DeleteById(id);
        }
        public void UpdateById(TaxiDriverEntityBLL taxiDriver, int id)
        {
            TaxiDriverDALService service = new TaxiDriverDALService(path);
            service.UpdateById(taxiDriver.TaxiDriverBLLtoDAL(), id);
        }
        public void Dancing(int id)
        {
            var service = new TaxiDriverDALService(path);
            var list = service.GetList().TaxiDriverListDALtoBLL();
            list[id].CountDance++;
            service.UpdateById(list[id].TaxiDriverBLLtoDAL(), id);
        }

        public void SetLicenseID(int id)
        {
            var service = new TaxiDriverDALService(path);
            var list = service.GetList().TaxiDriverListDALtoBLL();
            list[id].LicenseID = new Random().Next(100000, 999999).ToString();
            service.UpdateById(list[id].TaxiDriverBLLtoDAL(), id);
        }
    }
}
