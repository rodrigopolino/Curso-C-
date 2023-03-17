using System;

namespace Aula1_Enum.Entities.Enums
{
    enum OrderStatus : int 
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
