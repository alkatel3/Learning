using System;

namespace ConsoleApp37
{
    public class Kiborg : ICar, IPerson
    {
        public void cread()
        {
            throw new NotImplementedException();
        }

        double ICar. Move(int distanse)
        {
            return distanse / 100;
        }

        int IPerson.Move(int distanse)
        {
            return distanse / 5;
        }
    }
}
