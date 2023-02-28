using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProductManufacture> ProductManufactures { get; } = new List<ProductManufacture>();
}
