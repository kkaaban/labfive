using EntityDAL;
using JSONProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDALService
{
    public class AcrobatDALService
    {
        readonly string path;
        public AcrobatDALService(string path)
        {
            this.path = path;
        }
        public void Create(AcrobatEntityDAL acrobat)
        {
            List<AcrobatEntityDAL> list = new List<AcrobatEntityDAL>();
            list.Add(acrobat);
            Serialization<AcrobatEntityDAL>.Serialize(list, path);
        }
        public List<AcrobatEntityDAL> GetList()
        {
            List<AcrobatEntityDAL> list = new List<AcrobatEntityDAL>();
            list = Serialization<AcrobatEntityDAL>.DeSerialize(path);
            return list;
        }
        public void Add(AcrobatEntityDAL acrobat)
        {
            List<AcrobatEntityDAL> list = new List<AcrobatEntityDAL>();
            list = Serialization<AcrobatEntityDAL>.DeSerialize(path);
            list.Add(acrobat);
            Serialization<AcrobatEntityDAL>.Serialize(list, path);
        }
        public void DeleteById(int id)
        {
            List<AcrobatEntityDAL> list = new List<AcrobatEntityDAL>();
            list = Serialization<AcrobatEntityDAL>.DeSerialize(path);
            list.RemoveAt(id);
            Serialization<AcrobatEntityDAL>.Serialize(list, path);
        }
        public void UpdateById(AcrobatEntityDAL acrobat, int id)
        {
            List<AcrobatEntityDAL> list = new List<AcrobatEntityDAL>();
            list = Serialization<AcrobatEntityDAL>.DeSerialize(path);
            list[id] = acrobat;
            Serialization<AcrobatEntityDAL>.Serialize(list, path);
        }
    }
}
