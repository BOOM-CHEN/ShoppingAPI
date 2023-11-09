using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Dto.OrderDto
{
    public class OrderAddDto
    {
        public Guid UserId { get; set; }
        public string? OrderDate { get; set; }
        public float? OrderTotalPrice { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public string? ShoppingAddress { get; set; }
    }
}
