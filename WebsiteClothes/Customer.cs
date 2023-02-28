using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class Customer
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public decimal Balance { get; set; }

    public string Email { get; set; } = null!;

    public string? Promocodes { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<Shipping> Shippings { get; } = new List<Shipping>();
}
