using System;
using System.Collections.Generic;

namespace WebsiteClothes;

public partial class Material
{
    public int Id { get; set; }

    public string MaterialName { get; set; } = null!;

    public int MaterialQuality { get; set; }

    public int ProductId { get; set; }

    public virtual ICollection<MaterialProductRelation> MaterialProductRelations { get; } = new List<MaterialProductRelation>();
}
