namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static PhoneBook myPhoneBook = new PhoneBook();

        public static void Main(string[] args)
        {
            SeedPhoneBookWithData();
            Console.WriteLine("Phone book");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Write Location <...Name...>, Badge <...ID...> or Quit");
            string textFromLine;
            while (true)
            {
                textFromLine = Console.ReadLine();
                var commands = textFromLine.Split(' ');
                switch (commands[0])
                {
                    case "Location":
                        AllEmployeesInLocation(commands[1]);
                        break;
                    case "Badge":
                        DisplayEmployeeByBadgeId(commands[1]);
                        break;
                    case "Quit":
                        return;
                    default:
                        Console.WriteLine("Unknown value");
                        break;
                }
            }
        }

        public static void SeedPhoneBookWithData()
        {
            var employee1 = new Employee("Wojtek", "Pierog", 22222, Locations.Koszalin, "555-555");
            var employee2 = new Employee("Bartek", "Naskar", 90909, Locations.Warszawa, "111-111");
            var employee3 = new Employee("Marek", "NieMarek", 333333, Locations.Szczecin, "333-333");
            var employee4 = new Employee("Marcin", "Rek", 11111, Locations.Szczecin, "125-125");

            myPhoneBook.AddEmployee(employee1);
            myPhoneBook.AddEmployee(employee2);
            myPhoneBook.AddEmployee(employee3);
            myPhoneBook.AddEmployee(employee4);
        }

        public static void DisplayEmployeeByBadgeId(string badgeId)
        {
            int parsedBadgeId = int.Parse(badgeId);
            Console.WriteLine(myPhoneBook.GetEmployeeByBadgeId(parsedBadgeId).PrintEmployeeAdvancedInfo());
        }

        private static void AllEmployeesInLocation(string location)
        {
            Locations parseDepartment;
            Enum.TryParse(location, out parseDepartment);
            var employeesFromLocation = myPhoneBook.EmployeesFromLocation(parseDepartment);
            string result = string.Empty;
            employeesFromLocation.ForEach(e => result += $"{ e.PrintEmployeeAdvancedInfo()}");
            Console.WriteLine(result);
        }
    }
}