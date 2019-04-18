namespace PhoneBookTests
{
    using System;
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
            Assert.That(employee1.PrintEmployeeAdvancedInfo, Is.EqualTo("Name: " + employee1.Name + " Surname: " + employee1.Surname + " BadgeID: " + employee1.BadgeID + " Location: " + employee1.Department + " Phone: " + employee1.InternalPhone));
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
    }
}