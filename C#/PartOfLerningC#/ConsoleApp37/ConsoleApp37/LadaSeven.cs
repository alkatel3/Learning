using System;


namespace ConsoleApp37
{
    class LadaSeven : ICar
    {
        public void cread()
        {
            throw new NotImplementedException();
        }

        public double Move(int distanse)
        {
            return distanse / 40.0;
        }
    }
}
