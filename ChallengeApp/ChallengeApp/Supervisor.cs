namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Adam";

        public string Surname => throw new NotImplementedException();
        private List<float> Grades = new List<float>();

        //public Statistics GetStatistics()
        //{
        //    throw new NotImplementedException();
        //}

        public void AddGrade(float grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }

        public void AddGrade(double grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }

        public void AddGrade(char grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.Grades.Add(100);
                    break;
                case "-6" or "6-":
                    this.Grades.Add(95);
                    break;
                case "5+" or "+5":
                    this.Grades.Add(85);
                    break;
                case "5":
                    this.Grades.Add(80);
                    break;
                case "-5" or "5-":
                    this.Grades.Add(75);
                    break;
                case "+4" or "4+":
                    this.Grades.Add(65);
                    break;
                case "4":
                    this.Grades.Add(60);
                    break;
                case "-4" or "4-":
                    this.Grades.Add(55);
                    break;
                case "3+" or "+3":
                    this.Grades.Add(45);
                    break;
                case "3":
                    this.Grades.Add(40);
                    break;
                case "-3" or "3-":
                    this.Grades.Add(35);
                    break;
                case "+2" or "2+":
                    this.Grades.Add(25);
                    break;
                case "2":
                    this.Grades.Add(20);
                    break;
                case "-2" or "2-":
                    this.Grades.Add(15);
                    break;
                case "+1" or "1+":
                    this.Grades.Add(5);
                    break;
                case "1":
                    this.Grades.Add(0);
                    break;
                default:
                    throw new Exception("Invalid grade Value");
            }
        }

        public void AddGrade(int grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            foreach (var grade in this.Grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.Grades.Count;

            switch (statistics.Average)
            {
               
                case var average when average >= 90:
                    statistics.AverageLetter = '6';
                    break;
                case var average when average >= 70:
                    statistics.AverageLetter = '5';
                    break;
                case var average when average >= 50:
                    statistics.AverageLetter = '4';
                    break;
                case var average when average >= 30:
                    statistics.AverageLetter = '3';
                    break;
                case var average when average >= 10:
                    statistics.AverageLetter = '2';
                    break;
                default:
                    statistics.AverageLetter = '1';
                    break;
            }
            return statistics;
        }


    }
}
