using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HochiOrders
{
    public string OrderID { get; set; } = null!;

    public string? SourceOrderID { get; set; }

    public DateTime OrderDate { get; set; }

    public string? OrderStatus { get; set; }

    public string? IsPreOrder { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Currency { get; set; }

    public string? PaymentOrderID { get; set; }

    public decimal? PaymentTotal { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? ShippingFee { get; set; }

    public decimal? AdditionalFee { get; set; }

    public decimal? Discount { get; set; }

    public decimal? CreditUsed { get; set; }

    public decimal? OrderTotal { get; set; }

    public string? OrderNote { get; set; }

    public string? ShippingMethod { get; set; }

    public string? ShippingStatus { get; set; }

    public string? RecipientName { get; set; }

    public string? RecipientPhone { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateOrRegion { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string? AdminNote { get; set; }

    public string? StoreName { get; set; }

    public string? TaxID { get; set; }

    public string? InvoiceAddress { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? ProductOption { get; set; }

    public decimal? ProductPrice { get; set; }

    public decimal? CheckoutPrice { get; set; }

    public string? CheckoutPriceType { get; set; }

    public int? Quantity { get; set; }

    public string? ProductType { get; set; }

    public string? DistributionPoint { get; set; }

    public int? ExportID { get; set; }
}
