using Shopping.ShoppingEntity.Models.TKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Models
{
    public class Order : RootTKey<Guid>
    {
        /*public enum Status
        {
            PendingPayment, // 待付款
            Paid, // 已付款
            PreparingForShipment, // 准备发货
            Shipped, // 已发货
            InTransit, // 配送中
            Delivered, // 已签收
            Refunding, // 退款中
            RefundSuccessful, // 退款成功
            Completed // 交易完成
        }*/
        public Guid UserId { get; set; }
        public string? OrderDate { get; set; }
        public float? OrderTotalPrice { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public string? ShoppingAddress { get; set; }
        public User? User { get; set; }
    }
}
