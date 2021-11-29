using BLLException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntityBLL
{
    public abstract class BaseEntityBLL
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                string pattern = @"\p{IsCyrillic}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentExceptionProperNoun();
                }
                else
                    firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                string pattern = @"\p{IsCyrillic}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentExceptionProperNoun();
                }
                else
                    lastName = value;
            }
        }
        private string passportID;
        public string PassportID
        {
            get
            {
                return passportID;
            }
            set
            {
                string pattern = "^[0-9]{9}$|^[A-Z]{2}[0-9]{6}$";
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new ArgumentExceptionPassID();
                }
                else
                    passportID = value;
            }
        }
        public uint CountDance { get; set; }
    }
}
