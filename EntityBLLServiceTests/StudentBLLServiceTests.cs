using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityBLLService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityBLL;
using System.IO;

namespace EntityBLLService.Tests
{
    [TestClass()]
    public class StudentBLLServiceTests
    {
        string path = @"C:\Users\Крот\Desktop\lab5\EntityBLLServiceTests\Temp";

        [TestMethod()]
        public void Create_should_createFileSerialazed()
        {
            // arrange
            var service = new StudentBLLService(path + "\\test.json");
            var student = new StudentEntityBLL();
            File.Delete(path + "\\test.json");

            // act
            service.Create(student);

            // assert
            Assert.IsTrue(File.Exists(path + "\\test.json"));
        }

        [TestMethod()]
        public void Create_should_Serialazed_studentHaveValueInDormitoryNumber_whenCityIsKyiv()
        {
            // arrange
            var service = new StudentBLLService(path + "\\test.json");
            var student = new StudentEntityBLL()
            {
                City = "Київ",
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                StudentID = "DR00223344",
                Course = "3"
            };
            File.Delete(path + "\\test.json");

            // act
            service.Create(student);

            // assert
            Assert.IsNotNull(service.GetList()[0].DormitoryNumber);
        }

        [TestMethod()]
        public void Percent1CourseOtherCity_should_return_50_when_1of2_1courseNoKyiv()
        {
            // arrange
            var service = new StudentBLLService(path + "\\test.json");
            var student1 = new StudentEntityBLL()
            {
                City = "Київ",
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                StudentID = "DR00223344",
                Course = "3"
            };
            var student2 = new StudentEntityBLL()
            {
                City = "Житомир",
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                StudentID = "DR00223344",
                Course = "1"
            };
            File.Delete(path + "\\test.json");
            service.Create(student1);
            service.Add(student2);

            // act
            int expected = service.Percent1CourseOtherCity();

            // assert
            Assert.AreEqual(expected, 50);
        }

        [TestMethod()]
        public void DeleteById_should_delete_studentId1()
        {
            // arrange
            var service = new StudentBLLService(path + "\\test.json");
            var student = new StudentEntityBLL()
            {
                City = "Київ",
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                StudentID = "DR00223344",
                Course = "3"
            };
            File.Delete(path + "\\test.json");
            service.Create(student);

            // act
            service.DeleteById(0);

            // assert
            Assert.IsTrue(service.GetList().Count == 0);
        }

        [TestMethod()]
        public void UpdateById_should_updateStudent()
        {
            // arrange
            var service = new StudentBLLService(path + "\\test.json");
            var student1 = new StudentEntityBLL();
            File.Delete(path + "\\test.json");
            service.Create(student1);
            var student2 = new StudentEntityBLL()
            {
                City = "Житомир",
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                StudentID = "DR00223344",
                Course = "3"
            };

            // act
            service.UpdateById(student2, 0);
            var student3 = service.GetList()[0];

            // assert
            Assert.IsTrue(student2.FirstName == student3.FirstName &&
                student3.LastName == student2.LastName &&
                student2.City == student3.City &&
                student2.PassportID == student3.PassportID &&
                student2.Course == student3.Course);
        }

        [TestMethod()]
        public void Dancing_should_incrementCountDance()
        {
            // arrange
            var service = new StudentBLLService(path + "\\test.json");
            var student = new StudentEntityBLL()
            {
                City = "Київ",
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                StudentID = "DR00223344",
                Course = "3"
            };
            File.Delete(path + "\\test.json");
            service.Create(student);

            // act
            service.Dancing(0);

            // assert
            Assert.IsTrue(service.GetList()[0].CountDance==1);
        }
    }
}