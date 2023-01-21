using System;
using System.Collections;

namespace UserTypeInArrayList
{
    class DateComparer:IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).BirthDate, (y as Student).BirthDate);
            }
            throw new NotImplementedException();
        }
    }
}
