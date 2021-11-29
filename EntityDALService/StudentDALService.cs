using EntityDAL;
using JSONProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDALService
{
    public class StudentDALService
    {
        public StudentDALService(string path)
        {
            this.path = path;
        }
        private readonly string path;
        public void Create(StudentEntityDAL student)
        {
            List<StudentEntityDAL> list = new List<StudentEntityDAL>();
            list.Add(student);
            Serialization<StudentEntityDAL>.Serialize(list, path);
        }
        public List<StudentEntityDAL> GetList()
        {
            List<StudentEntityDAL> list = new List<StudentEntityDAL>();
            list = Serialization<StudentEntityDAL>.DeSerialize(path);
            return list;
        }
        public void Add(StudentEntityDAL student)
        {
            List<StudentEntityDAL> list = new List<StudentEntityDAL>();
            list = Serialization<StudentEntityDAL>.DeSerialize(path);
            list.Add(student);
            Serialization<StudentEntityDAL>.Serialize(list, path);
        }
        public void DeleteById(int id)
        {
            List<StudentEntityDAL> list = new List<StudentEntityDAL>();
            list = Serialization<StudentEntityDAL>.DeSerialize(path);
            list.RemoveAt(id);
            Serialization<StudentEntityDAL>.Serialize(list, path);
        }
        public void UpdateById(StudentEntityDAL student, int id)
        {
            List<StudentEntityDAL> list = new List<StudentEntityDAL>();
            list = Serialization<StudentEntityDAL>.DeSerialize(path);
            list[id] = student;
            Serialization<StudentEntityDAL>.Serialize(list, path);
        }
    }
}
