using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class MaterialProductRelation
{
    public int Id { get; set; }

    public int MaterialId { get; set; }

    public int ProductId { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
