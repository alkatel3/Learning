using System;


namespace ConsoleApp61
{
    class MyNewException : Exception
    {
        public MyNewException():base("My exception")
        {
        }
        public MyNewException(string massage):base (massage)
        {

        }
    }
}
