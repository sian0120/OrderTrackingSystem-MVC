using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTrackingSystem.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required, StringLength(20)]
        public string OrderNo { get; set; }

        [Required, StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(20)]
        public string CustomerPhone { get; set; }

        [StringLength(100)]
        public string CustomerEmail { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [StringLength(20)]
        public string OrderStatus { get; set; }

        [StringLength(20)]
        public string PaymentMethod { get; set; }

        [StringLength(200)]
        public string ShippingAddress { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public DateTime? UpdateTime { get; set; }
    }
}
