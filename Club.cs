using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Club
    {
        List<Membership> membershipList;
        public Club()
        {
            //membershipList.Add(new MemberShip(new DateTime(1996, 01, 01)));
            this.membershipList = new List<Membership>();
        }
        
        public void addMembership(Membership mem)
        {
            this.membershipList.Add(mem);
        }

        public double getTotalContribution()
        {
            double total = 0;
            foreach (Membership memberShip in membershipList)
            {
                total += memberShip.Fee;

            }
            return total;
        }
        public Member getYoungest()
        {
            int young = 100;
            Member youngestM = null;
            foreach (Membership membership in membershipList)
            {
                if (membership.member.Age() < young)
                {
                    youngestM = membership.member;
                    young = membership.member.Age();
                }
            }
            return youngestM;
        }
        public int getAverageNumberYearsOfMemberships()
        {
            int average = 0;
            foreach (Membership membership in membershipList)
            {
                average += membership.durationMembership(membership.RegistrationDate);
            }
            average /= membershipList.Count;
            return average;
        }
    }
}
