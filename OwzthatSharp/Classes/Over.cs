using System;
using System.Collections.Generic;

namespace OwzthatSharp
{
    public class Over
    {
        public int Order;
        public List<Ball> Balls;
        public Over(int order)
        {
            Order = order;
            Balls = new List<Ball>();
        }

        public void Simulate()
        {
            for (var i = 1; i <= 6; i++)
            {
                Console.Write("({0}.{1}): ", Order, i);
                var ball = new Ball(i);
                ball.Simulate();
                Balls.Add(ball);
            }
            Console.WriteLine("End of over {0}", Order);
        }
    }
}