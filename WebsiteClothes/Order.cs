using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class Order
{
    public int Id { get; set; }

    public int ShippingId { get; set; }

    public int ProductsId { get; set; }

    public virtual Product Products { get; set; } = null!;

    public virtual Shipping Shipping { get; set; } = null!;
}
