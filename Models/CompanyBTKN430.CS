using System.ComponentModel.DataAnnotations;


namespace BuiThiKimNgan430.Models
{
public class CompantBTKN430
{
    [Key]
    [StringLength(20)]
    public string? CompanyId {get;set;}
    [StringLength(50)]
    public string? CompanyName{get;set;}
   
}
}

