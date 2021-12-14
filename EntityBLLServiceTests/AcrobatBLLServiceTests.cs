using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityBLL;
using System.IO;

namespace EntityService.Tests
{
    [TestClass()]
    public class AcrobatBLLServiceTests
    {
        string path = @"C:\Users\Крот\Desktop\lab5\EntityBLLServiceTests\Temp";
        [TestMethod()]
        public void Dancing_should_incrementCountDance()
        {
            // arrange
            var service = new AcrobatBLLService(path + "\\test.json");
            var driver = new AcrobatEntityBLL()
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                TypeOfAcrobatics = "wals"
            };
            File.Delete(path + "\\test.json");
            service.Create(driver);

            // act
            service.Dancing(0);

            // assert
            Assert.IsTrue(service.GetList()[0].CountDance == 1);
        }
    }
}