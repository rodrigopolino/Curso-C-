using Aula1_Enum.Entities;
using Aula1_Enum.Entities.Enums;
namespace Aula1_Enum;

internal class Program
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
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
    }
}