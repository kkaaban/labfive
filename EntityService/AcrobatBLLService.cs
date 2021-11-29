using EntityBLL;
using EntityDAL;
using EntityDALService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;

namespace EntityService
{
    public class AcrobatBLLService
    {
        readonly string path;
        public AcrobatBLLService(string path)
        {
            this.path = path;
        }
        public void Create(AcrobatEntityBLL acrobat)
        {
            AcrobatDALService service = new AcrobatDALService(path);
            service.Create(acrobat.AcrobatBLLtoDAL());
        }
        public List<AcrobatEntityBLL> GetList()
        {
            List<AcrobatEntityBLL> list;
            AcrobatDALService service = new AcrobatDALService(path);
            list = service.GetList().AcrobatListDALtoBLL();
            return list;
        }
        public void Add(AcrobatEntityBLL acrobat)
        {
            AcrobatDALService service = new AcrobatDALService(path);
            service.Add(acrobat.AcrobatBLLtoDAL());
        }
        public void DeleteById(int id)
        {
            AcrobatDALService service = new AcrobatDALService(path);
            service.DeleteById(id);
        }
        public void UpdateById(AcrobatEntityBLL acrobat, int id)
        {
            AcrobatDALService service = new AcrobatDALService(path);
            service.UpdateById(acrobat.AcrobatBLLtoDAL(), id);
        }
        public void Dancing(int id)
        {
            var service = new AcrobatDALService(path);
            var list = service.GetList().AcrobatListDALtoBLL();
            list[id].CountDance++;
            service.UpdateById(list[id].AcrobatBLLtoDAL(), id);
        }
    }
}
