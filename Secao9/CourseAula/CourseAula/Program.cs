using System;
using CourseAula.Entities;
using CourseAula.Entities.Enums;

namespace CourseAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus status = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(status);
            Console.WriteLine(txt);

        }
    }
}