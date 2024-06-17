using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class Holiday
{
    [Key]      
    public int HolidayId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    [MaxLength(100)]
    public string Description { get; set; }
}
