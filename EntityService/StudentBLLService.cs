using EntityBLL;
using EntityDALService;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBLLService
{
    public class StudentBLLService
    {
        public StudentBLLService(string path)
        {
            this.path = path;
        }
        private readonly string path;

        public void Create(StudentEntityBLL student)
        {
            if (!(student.City == "Киев" | student.City == "Київ"))
                student.DormitoryNumber = new Random().Next(1, 13);

            StudentDALService service = new StudentDALService(path);
            service.Create(student.StudentBLLtoDAL());
        }
        public List<StudentEntityBLL> GetList()
        {
            List<StudentEntityBLL> list;
            StudentDALService service = new StudentDALService(path);
            list = service.GetList().StudentListDALtoBLL();
            return list;
        }
        public int Percent1CourseOtherCity()
        {
            StudentDALService service = new StudentDALService(path);
            var list = service.GetList().StudentListDALtoBLL();
            int count = 0;
            foreach (var student in list)
            {
                if (!(student.City == "Киев" | student.City == "Київ"))
                {
                    if (student.Course == "1")
                    {
                        count++;
                    }
                }
            }
            return (100/list.Count) * count;
        }
        public void Add(StudentEntityBLL student)
        {
            if (!(student.City == "Киев" | student.City == "Київ"))
                student.DormitoryNumber = new Random().Next(1, 13);

            StudentDALService service = new StudentDALService(path);
            service.Add(student.StudentBLLtoDAL());
        }
        public void DeleteById(int id)
        {
            StudentDALService service = new StudentDALService(path);
            service.DeleteById(id);
        }
        public void UpdateById(StudentEntityBLL student, int id)
        {
            if (!(student.City == "Киев" | student.City == "Київ"))
                student.DormitoryNumber = new Random().Next(1, 13);

            StudentDALService service = new StudentDALService(path);
            service.UpdateById(student.StudentBLLtoDAL(), id);
        }
        public void Dancing(int id)
        {
            var service = new StudentDALService(path);
            var list = service.GetList().StudentListDALtoBLL();
            list[id].CountDance++;
            service.UpdateById(list[id].StudentBLLtoDAL(), id);
        }
    }
}
