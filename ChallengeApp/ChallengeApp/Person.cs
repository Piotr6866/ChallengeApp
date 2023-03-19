namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name)
            : this(name, "no surname", "no sex")
        {
        }
        public Person(string name, string surname)
            : this(name, surname, "no sex")
        {
        }

        public Person(string name, string surname, string sex)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string sex { get; private set; }
    }
}