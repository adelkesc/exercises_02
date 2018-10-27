using System;
using System.Collections.Generic;

namespace Exercise_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Animal("Elephant", 90, 10));
            animals.Add(new Animal("Cheetah", 35, 70));
            animals.Add(new Animal("Cassowary", 20, 10));
            animals.Add(new Animal("Tiger", 60, 10));
            animals.Add(new Animal("Bear", 40, 10));
            animals.Add(new Animal("Antelope", 30, 10));
            animals.Add(new Animal("Crocodile", 60, 10));
            animals.Add(new Animal("Wolf", 30, 10));
            animals.Add(new Animal("Lemur", 10, 10));
            animals.Add(new Animal("Horse", 40, 10));

            animals.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine();

            animals.Sort();
            animals.ForEach(Console.WriteLine);
        }
    }
}