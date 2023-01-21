using System;
using System.Collections.Generic;

namespace Iterator
{
    class Auditory
    {
        List<Student> _auditory = new List<Student>
        {
            new Student("John","Miller", new DateTime(1997,3,12)),
            new Student("Candice","Leman",new DateTime(1998,7,22)),
            new Student("Joey","Finch",new DateTime(1996,11,30)),
            new Student("Nicole", "Taylor",new DateTime(1996,5,10)),
        };
        public IEnumerator<Student> GetEnumerator()
        {
            for (int i=0; i < _auditory.Count; i++)
            {
                yield return _auditory[i];
            }
        }
    }
}
