using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Models
{
    public class MessageModel<Type>
    {
        public int? Status { get; set; }
        public bool? Success { get; set; } = false;
        public string? Message { get; set; }
        public Type? Data { get; set; }
    }
}
