﻿namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling the Person class 
            Person Alice = new Person("Alice","Jackson" ,25, "Female", 1.30, 55, "dancing");
            Person Bob = new Person("Bob", "Benson", 22, "Male", 1.80, 75, "Gaming");

            //Calling the Fruit class
            Fruit Apple = new Fruit("Apple", "Red", 0.5);
            Fruit Banana = new Fruit("Banana", "Yellow", 0.25);
            Fruit Watermelon = new Fruit("Watermelon", "Green", 1.25);

            Console.WriteLine("Person 1's Information: \nName: " + Alice.GetName() + "\nSurname: " + Alice.GetSurname() + "\nAge: " +
                Alice.GetAge() + "\nGender: " + Alice.GetGender() + "\nHeight: " + Alice.GetHeight() + "\nWeight: " + Alice.GetWeight() + 
                "\nHobbies: " + Alice.GetHobbies() + "\nWhat fruit is " + Alice.GetName() + " eating? " + Apple.GetName());
            Console.WriteLine("\n\nPerson 2's Information: \nName: " + Bob.GetName() + "\nSurname: " + Bob.GetSurname() + "\nAge: " +
                Bob.GetAge() + "\nGender: " + Bob.GetGender() + "\nHeight: " + Bob.GetHeight() + "\nWeight: " + Bob.GetWeight() +
                "\nHobbies: " + Bob.GetHobbies() + "\nWhat fruit is " + Bob.GetName() + " eating? " + Watermelon.GetName());  
        }
    }
}
