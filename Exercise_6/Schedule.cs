using System;
using System.Collections;

namespace Exercise_6
{
    public class Schedule
    {
        Hashtable hashIndex = new Hashtable();

        // Indexer
        public string this[DateTime date]
            {
                get{ return hashIndex[date].ToString();}
                set{ hashIndex[date] = value;}
            }
    }
}