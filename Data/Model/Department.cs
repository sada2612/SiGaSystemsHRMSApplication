using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class Department
{
    [Key]        
    public int DepartmentId { get; set; }

    [Required]
    [MaxLength(100)]
    public string DepartmentName { get; set; }
}
