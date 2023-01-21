using System;


namespace Project1
{
    class FailSoftArray
    {
        int[] a;
        public int Length { get; private set; }
        //public bool ErrFlag { get; private set; }
        int lowerBound;
        int upperBound;    
        public FailSoftArray(int low,int upp)
        {
            upp ++;
            if (low >= upp)
            {
                Console.WriteLine("Не коректні границі");
                low = 0;
                upp = 1;
            }
            a = new int[upp - low];
            Length = upp - low;
            lowerBound = low;
            upperBound = --upp;
        }
        public int this [int index]
        {
            get
            {
                if (ok(index))
                {
                    //ErrFlag = false;
                    return a[index-lowerBound];
                }
                else
                {
                    //ErrFlag = true;
                    return 0;
                }
            }
            set
            {
                if (ok(index))
                {
                    a[index-lowerBound] = value;
                    //ErrFlag = false;
                }
                else
                {
                    if (Graduat(index))
                    {
                        int[] b = new int[index-lowerBound];
                        for(int i = 0; i < Length; i++)
                        {
                            b[i] = a[i];
                        }
                        a = b;
                        Length = (index+1)-lowerBound;
                        upperBound = index;
                        //ErrFlag = false;
                    }
                    else
                    {
                        int[] b = new int[upperBound-index  ];
                        for (int i = 0; i < Length; i++)
                        {
                            b[i] = a[i];
                        }
                        a = b;
                        Length = (upperBound+1) - index;
                        lowerBound = index;
                        //ErrFlag = true;
                    }
                }
            }
        }
        //public int this[double idx]
        //{
        //    get
        //    {
        //        int index;
        //        if ((idx - (int)idx) < 0.5)
        //        {
        //            index = (int)idx;
        //        }
        //        else
        //        {
        //            index = (int)idx + 1;
        //        }
        //        if (ok(index))
        //        {
        //            ErrFlag = false;
        //            return a[index];
        //        }
        //        else
        //        {
        //            ErrFlag = true;
        //            return 0;
        //        }
        //    }
        //    set
        //    {
        //        int index;
        //        if ((idx - (int)idx) < 0.5)
        //        {
        //            index = (int)idx;
        //        }
        //        else
        //        {
        //            index = (int)idx + 1;
        //        }
        //        if (ok(index))
        //        {
        //            ErrFlag = false;
        //            a[index]=value;
        //        }
        //        else
        //        {
        //            ErrFlag = true;
        //        }
        //    }
        //}
        private bool ok(int index)
        {
            if (index >= lowerBound & index <= upperBound)
            {
                return true;
            }
            return false;
        }
        private bool Graduat(int index)
        {
            if (index >upperBound)
            {
                return true;
            }
            return false;
        }
    }
}
