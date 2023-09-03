﻿using DAL.EF.Models;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public decimal ShippingCost { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string TrackingNumber { get; set; }
        public string PromoCode { get; set; }
        public decimal TaxAmount { get; set; }
        public OrderPriority OrderPriority { get; set; }
        public decimal Discounts { get; set; }
        public Customer Customer { get; set; }
    }
}
