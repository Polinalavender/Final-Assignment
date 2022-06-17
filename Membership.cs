using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Membership
    {
        private DateTime registrationDate;
        private double fee;

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public Member member;

        public Membership(String name, DateTime dateOfBirth, DateTime dateOfJoining)
        {
            this.registrationDate = dateOfJoining;
            this.member = new Member(name, dateOfBirth, dateOfJoining);
        }
        public double getFee(int age)
        {
            //loop
            double baseFee = 0;

            if (age < 18)
            {
                baseFee = 75;
            }
            else if (age >= 18)
            {
                baseFee = 150;
            }
            if (durationMembership(registrationDate) > 7)
            {
                baseFee *= 0.95;
            }
            return baseFee;
        }
        public int durationMembership(DateTime registrationDate)
        {
            DateTime now = DateTime.Now;
            int duration = now.Year - registrationDate.Year;
            return duration;
        }
    }
}
