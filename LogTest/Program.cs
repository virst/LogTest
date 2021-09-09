using System;

namespace LogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Log.Logger.Info("Hello World!");

            try
            {
                for (int i = -4; i < 5; i++)
                {
                    int d = 44 / i;
                    Log.Logger.Info("d = " + d);
                }
            }
            catch (Exception e)
            {
                Log.Logger.Error(e);
            }
        }
    }
}
