using ChallengeApp;
namespace ChalengeApp.Tests

{
    public class Tests
    {
        [Test]
        public void CheckResultWithNegativeNumbers()
        {
            // arrange 
            var employee1 = new Employee("Johnny", "Walker", 33);
            employee1.AddScore(-3);
            employee1.AddScore(-5);

            // act    
            var result = employee1.Result;

            // assert  
            Assert.AreEqual(-8, result);
        }
    }
}