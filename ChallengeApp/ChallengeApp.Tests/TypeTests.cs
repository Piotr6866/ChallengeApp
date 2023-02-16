using ChallengeApp; 
namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoGetEmployeeShouldBeDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("John", "Brown", 33);
            var employee2 = GetEmployee("John", "Brown", 33);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void TwoIntegersShouldBeEqual()
        {
            // arrange
            int number1 = 123;
            int number2 = 123;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TwoStringNamesShouldBe()
        {
            // arrange
            string name1 = "Roman";
            string name2 = "Roman";

            //act

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void TwoDoubleNumbersShouldBeEqual()
        {
            // arrange
            double number1 = 1.2345;
            double number2 = 1.2345;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
