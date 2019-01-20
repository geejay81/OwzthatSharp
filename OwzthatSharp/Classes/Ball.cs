using System;

namespace OwzthatSharp
{
    public class Ball
    {
        public int Order;
        public int Runs { get; set; }

        public Ball(int order)
        {
            Order = order;
        }

        public void Simulate()
        {
            Runs = 1;
            Console.WriteLine("{0} runs scored.", Runs);
        }
    }
}