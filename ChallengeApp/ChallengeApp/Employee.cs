namespace ChallengeApp
{
    internal class Employee
    {
        private List<int> score = new List<int>();


        public Employee(string name, string surname, int age)       //konstruktor wywoływany jest gdy tworzony jest nowy obiekt
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }


        public string Name { get; private set; }         //property??? pola - parametry opisujące nasz obiekt

        public string Surname { get; private set; }
        
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)                              // metoda - w tym przypadku dodaje punkty Emploeeowi
        {
            this.score.Add(number);
        }
    }
}
