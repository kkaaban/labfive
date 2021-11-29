using EntityDAL;
using JSONProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDALService
{
    public class TaxiDriverDALService
    {
        readonly string path;
        public TaxiDriverDALService(string path)
        {
            this.path = path;
        }
        public void Create(TaxiDriverEntityDAL taxiDriver)
        {
            List<TaxiDriverEntityDAL> list = new List<TaxiDriverEntityDAL>();
            list.Add(taxiDriver);
            Serialization<TaxiDriverEntityDAL>.Serialize(list, path);
        }
        public List<TaxiDriverEntityDAL> GetList()
        {
            List<TaxiDriverEntityDAL> list = new List<TaxiDriverEntityDAL>();
            list = Serialization<TaxiDriverEntityDAL>.DeSerialize(path);
            return list;
        }
        public void Add(TaxiDriverEntityDAL taxiDriver)
        {
            List<TaxiDriverEntityDAL> list = new List<TaxiDriverEntityDAL>();
            list = Serialization<TaxiDriverEntityDAL>.DeSerialize(path);
            list.Add(taxiDriver);
            Serialization<TaxiDriverEntityDAL>.Serialize(list, path);
        }
        public void DeleteById(int id)
        {
            List<TaxiDriverEntityDAL> list = new List<TaxiDriverEntityDAL>();
            list = Serialization<TaxiDriverEntityDAL>.DeSerialize(path);
            list.RemoveAt(id);
            Serialization<TaxiDriverEntityDAL>.Serialize(list, path);
        }
        public void UpdateById(TaxiDriverEntityDAL taxiDriver, int id)
        {
            List<TaxiDriverEntityDAL> list = new List<TaxiDriverEntityDAL>();
            list = Serialization<TaxiDriverEntityDAL>.DeSerialize(path);
            list[id] = taxiDriver;
            Serialization<TaxiDriverEntityDAL>.Serialize(list, path);
        }
    }
}
