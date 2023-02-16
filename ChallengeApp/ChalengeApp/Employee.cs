namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private List<int> Score = new List<int>();

        public Employee(string Name, string lastName, int age)
        {
            this.Name = Name;
            this.LastName = lastName;
            this.Age = age;
        }
        public void AddScore(int number)
        {
            this.Score.Add(number);
        }
        public int Result
        {
            get 
            { 
                return this.Score.Sum(); 
            }
        }
    }
}
