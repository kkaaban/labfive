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
    public static class TaxiDriverMapper
    {
        public static TaxiDriverEntityBLL TaxiDriverPLtoBLL(this TaxiDriverEntity taxiDriver)
        {
            return new TaxiDriverEntityBLL
            {
                FirstName = taxiDriver.FirsName,
                LastName = taxiDriver.LastName,
                PassportID = taxiDriver.PassportID,
                CarModel = taxiDriver.CarModel,
                LicenseID = taxiDriver.LicenseID
            };
        }
        public static TaxiDriverEntityDAL TaxiDriverBLLtoDAL(this TaxiDriverEntityBLL taxiDriver)
        {
            return new TaxiDriverEntityDAL
            {
                FirsName = taxiDriver.FirstName,
                LastName = taxiDriver.LastName,
                PassportID = taxiDriver.PassportID,
                CountDance = taxiDriver.CountDance,
                CarModel = taxiDriver.CarModel,
                LicenseID = taxiDriver.LicenseID
            };
        }
        public static List<TaxiDriverEntityBLL> TaxiDriverListDALtoBLL(this List<TaxiDriverEntityDAL> list)
        {
            List<TaxiDriverEntityBLL> list2 = new List<TaxiDriverEntityBLL>();
            foreach (var taxiDriver in list)
            {
                list2.Add(new TaxiDriverEntityBLL
                {
                    FirstName = taxiDriver.FirsName,
                    LastName = taxiDriver.LastName,
                    PassportID = taxiDriver.PassportID,
                    CountDance = taxiDriver.CountDance,
                    CarModel = taxiDriver.CarModel,
                    LicenseID = taxiDriver.LicenseID
                });
            }
            return list2;
        }
        public static List<TaxiDriverEntity> TaxiDriverListBLLtoPL(this List<TaxiDriverEntityBLL> list)
        {
            List<TaxiDriverEntity> list2 = new List<TaxiDriverEntity>();
            foreach (var taxiDriver in list)
            {
                string danceCategory = "Отсутствует";
                if (taxiDriver.CountDance == 1)
                {
                    danceCategory = "1 ранг";
                }
                else if (taxiDriver.CountDance == 2)
                {
                    danceCategory = "2 ранг";
                }
                else if (taxiDriver.CountDance == 3)
                {
                    danceCategory = "3 ранг";
                }
                else if (taxiDriver.CountDance > 3 & taxiDriver.CountDance < 11)
                {
                    danceCategory = "Кандидат в мастера спорта";
                }
                else if (taxiDriver.CountDance > 10)
                {
                    danceCategory = "Мастер спорта";
                }
                list2.Add(new TaxiDriverEntity
                {
                    FirsName = taxiDriver.FirstName,
                    LastName = taxiDriver.LastName,
                    PassportID = taxiDriver.PassportID,
                    DanceCategory = danceCategory,
                    CarModel = taxiDriver.CarModel,
                    LicenseID = taxiDriver.LicenseID
                });
            }
            return list2;
        }
    }
}
