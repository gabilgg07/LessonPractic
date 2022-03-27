using System;

namespace PolymorphismLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Polymorphism Lesson----(tercumesi: yun.'Cox sekilli')");

            // Eyni adli methoddur lakin, ferqli classlarda ferqli is gorurler: 

            Animal animal = new Animal();
            animal.AnimalSound();

            Pig pig = new Pig();
            pig.AnimalSound();

            Dog dog = new Dog();
            dog.AnimalSound();

            Console.ReadKey();

        }

        // Overload Plymorphism-e bir numunedir.
        // Eyni adli methodun imzalariyla ferqlenerek ferqli isler gore bilmesi.

        static void Sum(int a, int b)
        {
            int s = a + b;
            Console.WriteLine($"Cem: {s}");
        }

        static void Sum(int a, int b, int c)
        {
            int s = a + b + c;
            Console.WriteLine($"Cem: {s}");
        }

        // Override de Plymorphism-e basqa bir numunesidir.

        class Animal // Base class (parent)
        {
            public void AnimalSound()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        class Pig : Animal // Derived class (child)
        {
            public void AnimalSound()
            {
                Console.WriteLine("The Pig says: wee wee");
            }
        }

        class Dog : Animal // Derived class (child)
        {
            public void AnimalSound()
            {
                Console.WriteLine("The Dog says: bow wow");
            }
        }

    }
}
