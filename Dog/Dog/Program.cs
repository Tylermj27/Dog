using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAssignment
{
    public enum gender
    {
        Male,
        Female
    }
    public class Dog
    {
        public string Name, Owner;
        public int Age;
        public gender Gender;


        public Dog(string name, string owner, int age, gender dogGender)
        {
        Name = name;
        Owner = owner;
        Age = age;
        Gender = dogGender;

        }

        public void Bark(int size)
        {
            int i;
            for(i = 0; i < size; i++)
            {
                Console.WriteLine("Woof!");
            }

        }

        public void GetTag()
        {
            string AgeWord, HisHer, HeShe;
            if (Age == 1)
            {
                AgeWord = "a year";
            }
            else
            {
                AgeWord = Age + " years";
            }
            if(Gender == gender.Male)
            {
                HisHer = "His";
                HeShe = "he";
            }
            else
            {
                HisHer = "Her";
                HeShe = "she";
            }

            Console.WriteLine("If lost, call {0}. {1} name is {2} and {3} is {4} old.\n", Owner, HisHer, Name, HeShe, AgeWord);
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, gender.Male);
            puppy.Bark(3);
            puppy.GetTag();


            Dog myDog = new Dog("Lileu", "Dale", 4, gender.Female);
            myDog.Bark(1);
            myDog.GetTag();

            Console.ReadLine();
        }
    }
}
