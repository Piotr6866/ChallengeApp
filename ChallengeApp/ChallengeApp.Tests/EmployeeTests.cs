using ChallengeApp;

namespace ChalengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckMaxResult()
        {
            // arrange 
            var employee1 = new Employee("Adam", "Nowak");
            employee1.AddGrade(3);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(9);
            employee1.AddGrade(10);
            // act    
            var statistics1 = employee1.GetStatistics();
            // assert  
            Assert.AreEqual(10, statistics1.Max);
        }

        [Test]
        public void CheckMinResult()
        {
            // arrange 
            var employee1 = new Employee("Adam", "Nowak");
            employee1.AddGrade(3);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(9);
            employee1.AddGrade(10);
            // act    
            var statistics1 = employee1.GetStatistics();
            // assert  
            Assert.AreEqual(3, statistics1.Min);
        }

        [Test]
        public void CheckAverageResult()
        {
            // arrange 
            var employee1 = new Employee("Adam", "Nowak");
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(9);
            employee1.AddGrade(10);
            // act    
            var statistics1 = employee1.GetStatistics();
            // assert  
            Assert.AreEqual(7, statistics1.Average);
        }
        [Test]
        public void WhenUserGetPoints_ShouldCorrectStatistics()
        {
            // arrange 
            var employeeAE = new Employee("Alano", "Espaniol");
            employeeAE.AddGrade('A');
            employeeAE.AddGrade('C');
            // act 
            var statistics = employeeAE.GetStatistics();
            // assert 
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual(80, statistics.Average);
            Assert.AreEqual('B', statistics.AverageLetter);

        }

    }
}