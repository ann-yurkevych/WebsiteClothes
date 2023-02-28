using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class ProductManufacture
{
    public int Id { get; set; }

    public int YearOfRelease { get; set; }

    public string NameProducer { get; set; } = null!;

    public string QualityRate { get; set; } = null!;

    public DateTime ExpirationDate { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
