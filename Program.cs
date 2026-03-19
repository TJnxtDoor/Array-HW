using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"car1", "car2", "car3", "car4"};
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
