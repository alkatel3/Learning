using System;


namespace Project1
{
    class PwrOfTwo
    {
       public bool GetFlag=true;
        public int this[int index] 
        {
            get
            {
                if(index>=0 && index <= 15)
                {
                    GetFlag = true;
                    return Pwr_Of_Two(index);
                }
                else
                {
                    GetFlag = false;
                    return 0;
                }
            }
        }
        private int Pwr_Of_Two(int index)
        {
            int result=1;
            for(int i = 0; i < index; i++)
            {
                result*= 2;
            }
            return result;
        }
    }
}
