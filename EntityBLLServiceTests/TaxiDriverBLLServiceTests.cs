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
    public class TaxiDriverBLLServiceTests
    {
        string path = @"C:\Users\Крот\Desktop\lab5\EntityBLLServiceTests\Temp";
        [TestMethod()]
        public void Dancing_should_incrementCountDance()
        {
            // arrange
            var service = new TaxiDriverBLLService(path + "\\test.json");
            var driver = new TaxiDriverEntityBLL()
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                CarModel = "Tesla"
            };
            File.Delete(path + "\\test.json");
            service.Create(driver);

            // act
            service.Dancing(0);

            // assert
            Assert.IsTrue(service.GetList()[0].CountDance == 1);
        }

        [TestMethod()]
        public void SetLicenseID_should_randomIdDriverLicense()
        {
            // arrange
            var service = new TaxiDriverBLLService(path + "\\test.json");
            var driver = new TaxiDriverEntityBLL()
            {
                FirstName = "Дмитро",
                LastName = "Крутов",
                PassportID = "000000000",
                CarModel = "Tesla"
            };
            File.Delete(path + "\\test.json");
            service.Create(driver);

            // act
            service.SetLicenseID(0);

            // assert
            Assert.IsNotNull(service.GetList()[0].LicenseID);
        }
    }
}