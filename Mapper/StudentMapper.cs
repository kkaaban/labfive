using Entity;
using EntityBLL;
using EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class StudentMapper
    {
        public static StudentEntityBLL StudentPLtoBLL(this StudentEntity student)
        {
            return new StudentEntityBLL()
            {
                FirstName = student.FirsName,
                LastName = student.LastName,
                PassportID = student.PassportID,
                Course = student.Course,
                StudentID = student.StudentID,
                City = student.City,
                DormitoryNumber = student.DormitoryNumber
            };
        }
        public static StudentEntityDAL StudentBLLtoDAL(this StudentEntityBLL student)
        {
            return new StudentEntityDAL
            {
                FirsName = student.FirstName,
                LastName = student.LastName,
                PassportID = student.PassportID,
                Course = student.Course,
                StudentID = student.StudentID,
                City = student.City,
                CountDance = student.CountDance,
                DormitoryNumber = student.DormitoryNumber
            };
        }
        public static List<StudentEntityBLL> StudentListDALtoBLL(this List<StudentEntityDAL> list)
        {
            List<StudentEntityBLL> list2 = new List<StudentEntityBLL>();
            foreach (var student in list)
            {
                list2.Add(new StudentEntityBLL() 
                {
                    FirstName = student.FirsName,
                    LastName = student.LastName,
                    PassportID = student.PassportID,
                    Course = student.Course,
                    StudentID = student.StudentID,
                    CountDance = student.CountDance,
                    City = student.City,
                    DormitoryNumber = student.DormitoryNumber
                });
            }
            return list2;
        }
        public static List<StudentEntity> StudentListBLLtoPL(this List<StudentEntityBLL> list)
        {
            List<StudentEntity> list2 = new List<StudentEntity>();
            foreach (var student in list)
            {
                string danceCategory = "Отсутствует";
                if (student.CountDance == 1)
                {
                    danceCategory = "1 ранг";
                }
                else if (student.CountDance == 2)
                {
                    danceCategory = "2 ранг";
                }
                else if (student.CountDance == 3)
                {
                    danceCategory = "3 ранг";
                }
                else if (student.CountDance > 3 & student.CountDance < 11)
                {
                    danceCategory = "Кандидат в мастера спорта";
                }
                else if (student.CountDance > 10)
                {
                    danceCategory = "Мастер спорта";
                }
                list2.Add(new StudentEntity
                {
                    FirsName = student.FirstName,
                    LastName = student.LastName,
                    PassportID = student.PassportID,
                    Course = student.Course,
                    StudentID = student.StudentID,
                    City = student.City,
                    DanceCategory = danceCategory,
                    DormitoryNumber = student.DormitoryNumber
                });
            }
            return list2;
        }
    }
}
