using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Member
    {
        private string name;
        private DateTime dateBirth;
        private DateTime dateJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }

        public DateTime DateJoining
        {
            get { return dateJoining; }
            set { dateJoining = value; }
        }
        public Member(string name, DateTime dateBirth, DateTime dateJoining)
        {
            this.name = name;
            this.dateBirth = dateBirth;
            this.dateJoining = dateJoining;
        }
        public int Age()
        {
            DateTime curr = DateTime.Now;
            int age = curr.Year - dateBirth.Year;
            return age;
        }
    }
}
