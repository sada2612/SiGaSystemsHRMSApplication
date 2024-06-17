using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class IncentivePurpose
{
    [Key]
    public int IncentivePurposeId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Purpose { get; set; }
}
