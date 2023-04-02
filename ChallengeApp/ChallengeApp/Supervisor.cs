namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name =>"Adam";

        public string Surname => throw new NotImplementedException();
        private List<float> Grades = new List<float>();

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {

            throw new NotImplementedException();
        }
    }
}
