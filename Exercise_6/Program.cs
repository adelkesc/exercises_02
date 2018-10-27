using System;
using System.Collections;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            var d1 = new DateTime(2018, 10, 23);

            Schedule plan = new Schedule();
            plan[(d1)] = "DNP";
            
            Console.WriteLine(plan);
            // i'm not sure how to print the hashtable and i'm questioning if i wrote the indexer or hashtable correctly.
            // i can only get as far as printing the object, but that is definitely not what i want.  
            // i can't figure out a way to print the date associated with the string.
        }
    }
}
