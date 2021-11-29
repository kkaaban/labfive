using BLLException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntityBLL
{
    public class StudentEntityBLL : BaseEntityBLL
    {
        private string course;
        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                string pattern = "^[1-6]{1}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentExceptionCourse();
                }
                else
                    course = value;
            }
        }
        private string studentID;
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                string pattern = "^[A-Z]{2}[0-9]{8}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentExceptionStudentID(); 
                }
                else
                    studentID = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                string pattern = @"\p{IsCyrillic}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentExceptionProperNoun();
                }
                else
                    city = value;
            }
        }
        private int dormitoryNumber;
        public int DormitoryNumber
        {
            get
            {
                return dormitoryNumber;
            }
            set
            {
                dormitoryNumber = value;
            }
        }
    }
}
