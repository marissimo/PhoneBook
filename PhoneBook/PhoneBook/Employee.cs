namespace PhoneBookTests
{
    using PhoneBook;

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

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int BadgeID { get; private set; }

        public Locations Department { get; private set; }

        public string InternalPhone { get; private set; }

        public string PrintEmployeeBasicInfo()
        {
            return $"Name:{Name} Location: {Department}";
        }

        public string PrintEmployeeAdvancedInfo()
        {
            return $"Name: {Name} Surname: {Surname} BadgeID: {BadgeID} Location: {Department} Phone: {InternalPhone}";
        }
    }
}
