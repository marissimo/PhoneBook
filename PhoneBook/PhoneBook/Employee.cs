namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        public Employee(string name, string surname, int badgeID, Locations department, string internalPhone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            this.BadgeID = badgeID;
            this.InternalPhone = internalPhone;
        }

        public string Name { get; }

        public string Surname { get; }

        public int BadgeID { get; }

        public Locations Department { get; }

        public string InternalPhone { get; }

        public string PrintEmployeeBasicInfo()
        {
            return $"Name:{Name} Location: {Department}";
        }

        public string PrintEmployeeAdvancedInfo()
        {
            return $"Name: {Name} \nSurname: {Surname} \nBadgeID: {BadgeID} \nLocation: {Department} \nPhone: {InternalPhone} \n\n";
        }
    }
}
