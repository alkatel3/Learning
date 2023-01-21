using System;


namespace ConsoleApp37
{
    class BMWSeven : ICar
    {
        public void cread()
        {
            throw new NotImplementedException();
        }

        public double Move(int distanse)
        {
            return distanse / 60.0;
        }
    }
}
