using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class Shipping
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal ShippingPrice { get; set; }

    public string ShippingWay { get; set; } = null!;

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
