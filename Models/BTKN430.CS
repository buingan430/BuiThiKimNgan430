using System.ComponentModel.DataAnnotations;
namespace BuiThiKimNgan430.Models
{
public class BTKN430
{
    [Key]
    [StringLength(20)]
    public string? BTKNId {get;set;}
    [StringLength(50)]
    public string? BTKNName{get;set;}
    public string? BTKNGender{get;set;}
    [Bolean]
}
}

