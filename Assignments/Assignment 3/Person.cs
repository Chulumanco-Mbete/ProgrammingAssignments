namespace Assignment_3
{
    internal class Person
    {
        // Fields to store the attributes of a person
        private string name;
        private string surname;
        private int age;
        private string gender;
        private double height; // in meters
        private double weight; // in kilograms
        private string hobbies;

        // A constructor to initialize a person object with given values
        public Person(string name,string surname ,int age, string gender, double height, double weight, string hobbies)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            this.hobbies = hobbies;
        }

        public string GetName()
        {
            return name;
        }
        
        public string GetSurname()
        {
            return surname;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetGender()
        {
            return gender;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }

        public string GetHobbies()
        {
            return hobbies;
        }

        /*public void Walk()
        {
            Console.WriteLine(name + " is walking.");
        }

        public void Talk(string message)
        {
            Console.WriteLine(name + " says: " + message);
        }

        public void Eat(string food)
        {
            Console.WriteLine(name + " is eating " + food + ".");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }

        public void Work(string job)
        {
            Console.WriteLine(name + " is working as a " + job + ".");
        }*/
    }
}
