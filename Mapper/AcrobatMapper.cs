using Entity;
using EntityBLL;
using EntityDAL;
using System.Collections.Generic;

namespace Mapper
{
    public static class AcrobatMapper
    {
        public static AcrobatEntityBLL AcrobatPLtoBLL(this AcrobatEntity acrobat)
        {
            return new AcrobatEntityBLL
            {
                FirstName = acrobat.FirsName,
                LastName = acrobat.LastName,
                PassportID = acrobat.PassportID,
                TypeOfAcrobatics = acrobat.TypeOfAcrobatics
            };

        }
        public static AcrobatEntityDAL AcrobatBLLtoDAL(this AcrobatEntityBLL acrobat)
        {
            return new AcrobatEntityDAL
            {
                FirsName = acrobat.FirstName,
                LastName = acrobat.LastName,
                PassportID = acrobat.PassportID,
                CountDance = acrobat.CountDance,
                TypeOfAcrobatics = acrobat.TypeOfAcrobatics
            };
        }
        public static List<AcrobatEntityBLL> AcrobatListDALtoBLL(this List<AcrobatEntityDAL> list)
        {
            List<AcrobatEntityBLL> list2 = new List<AcrobatEntityBLL>();
            foreach (var acrobat in list)
            {
                list2.Add(new AcrobatEntityBLL
                {
                    FirstName = acrobat.FirsName,
                    LastName = acrobat.LastName,
                    PassportID = acrobat.PassportID,
                    CountDance = acrobat.CountDance,
                    TypeOfAcrobatics = acrobat.TypeOfAcrobatics
                });
            }
            return list2;
        }
        public static List<AcrobatEntity> AcrobatListBLLtoPL(this List<AcrobatEntityBLL> list)
        {
            List<AcrobatEntity> list2 = new List<AcrobatEntity>();
            foreach (var acrobat in list)
            {
                string danceCategory = "Отсутствует";
                if (acrobat.CountDance == 1)
                {
                    danceCategory = "1 ранг";
                }
                else if (acrobat.CountDance == 2)
                {
                    danceCategory = "2 ранг";
                }
                else if (acrobat.CountDance == 3)
                {
                    danceCategory = "3 ранг";
                }
                else if (acrobat.CountDance > 3 & acrobat.CountDance < 11)
                {
                    danceCategory = "Кандидат в мастера спорта";
                }
                else if (acrobat.CountDance > 10)
                {
                    danceCategory = "Мастер спорта";
                }
                list2.Add(new AcrobatEntity
                {
                    FirsName = acrobat.FirstName,
                    LastName = acrobat.LastName,
                    PassportID = acrobat.PassportID,
                    DanceCategory = danceCategory,
                    TypeOfAcrobatics = acrobat.TypeOfAcrobatics
                });
            }
            return list2;
        }
    }
}
