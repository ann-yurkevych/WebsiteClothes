using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebsiteClothes;

public partial class Department
{
    public int Id { get; set; }
    [Required(ErrorMessage = "You should write info")]
    [Display(Name = "Categories")]
    public string DepartmentName { get; set; } = null!;
    [Display(Name = "Code")]
    public int DepartmentNameId { get; set; }
    [Display(Name = "Amount of discounts per year")]
    public int DepartmentSales { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
