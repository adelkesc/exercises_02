using System;
using System.Collections.Generic;


namespace Exercise_4
{
    class Animal : IComparable<Animal>
    {
        private string type;
        private double weight;
        private int runSpeed;

        public Animal(string type, double weight, int runSpeed)
        {
            this.type = type;
            this.weight = weight;
            this.runSpeed = runSpeed;
        }

        public override string ToString()
        {
            return "Animal Stats: Type - " + type +
                                 ": Weight - " + weight +
                                 ": Run Speed - " + runSpeed;
        }

        public int CompareTo(Animal obj)
        {
            // sort animals based on weight
            if(this.weight == obj.weight)
            {
                return this.weight.CompareTo(obj.weight);
            }
            return obj.weight.CompareTo(this.weight);
        }
        // How does this method return the result in the order that it does?
        // It doesn't seem like I'm defining anything aside from telling the method what to compare.
    }
}
