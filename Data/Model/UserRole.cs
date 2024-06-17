using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class UserRole
{
    [Key]
    public int UserRoleId { get; set; }

    [Required]
    [MaxLength(50)]
    public string RoleName { get; set; }
}
