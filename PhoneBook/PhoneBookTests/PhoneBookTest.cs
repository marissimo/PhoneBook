namespace PhoneBookTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using PhoneBook;

    [TestFixture]
    public class PhoneBookTests
    {
        [Test]
        public void Employee_InfoBasicEmployee() 
        {
            var employee1 = new Employee("Wojtek", "Pierog", 33333, Locations.Koszalin, "667667667");
            Console.WriteLine(employee1.PrintEmployeeBasicInfo());
            Assert.That(employee1.PrintEmployeeBasicInfo, Is.EqualTo("Name:" + employee1.Name + " Location: " + employee1.Department));    
        }

        [Test]
        public void Employee_InfoAdvancedEmployee()
        {
            var employee1 = new Employee("Wojtek", "Pierog", 33333, Locations.Koszalin, "667667667");
            Console.WriteLine(employee1.PrintEmployeeAdvancedInfo());
            Assert.That(employee1.PrintEmployeeAdvancedInfo, Is.EqualTo("Name: " + employee1.Name + " \nSurname: " + employee1.Surname + " \nBadgeID: " + employee1.BadgeID + " \nLocation: " + employee1.Department + " \nPhone: " + employee1.InternalPhone + " \n\n"));
        }

        [Test]
        public void Employee_ConstructorTest() 
        { 
            {
                var employee1 = new Employee("Wojtek", "Pierog", 33333, Locations.Koszalin, "667667667");
                Console.WriteLine(employee1.PrintEmployeeAdvancedInfo());
                Assert.That(employee1.Name, Is.EqualTo("Wojtek"));
                Assert.That(employee1.BadgeID, Is.EqualTo(33333));
                Assert.That(employee1.Surname, Is.EqualTo("Pierog"));
                Assert.That(employee1.Department, Is.EqualTo(Locations.Koszalin));
                Assert.That(employee1.InternalPhone, Is.EqualTo("667667667"));
            }
        }

        [Test]
        public void PhoneBook_Add_Employees()
        {
            var employee1 = new Employee("Wojtek", "Pierog", 22222, Locations.Koszalin, "555-555");
            var employee2 = new Employee("Bartek", "Naskar", 90909, Locations.Warszawa, "111-111");
            var employee3 = new Employee("Marek", "NieMarek", 333333, Locations.Szczecin, "333-333");
            var employee4 = new Employee("Marcin", "Rek", 11111, Locations.Szczecin, "125-125");

            var phoneBook = new PhoneBook();

            phoneBook.AddEmployee(employee1);
            phoneBook.AddEmployee(employee2);
            phoneBook.AddEmployee(employee3);
            phoneBook.AddEmployee(employee4);

            foreach (var newObject in phoneBook.EmployeesFromLocation(Locations.Szczecin))
            {
                Console.WriteLine(newObject.Name);
            }
        }
    }
}