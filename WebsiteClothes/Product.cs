using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string YearProduction { get; set; } = null!;

    public string YearRelease { get; set; } = null!;

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public int MaterialId { get; set; }

    public int DepartmentId { get; set; }

    public int ManufracturesId { get; set; }

    public virtual ProductManufacture Manufractures { get; set; } = null!;

    public virtual Department Material { get; set; } = null!;

    public virtual ICollection<MaterialProductRelation> MaterialProductRelations { get; } = new List<MaterialProductRelation>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
