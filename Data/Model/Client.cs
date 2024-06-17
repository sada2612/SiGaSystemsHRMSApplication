using Siga_Hrms.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class Client
{
    [Key]
    public int ClientId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(200)]
    public string CompanyName { get; set; }

    [MaxLength(100)]
    public string ContactPersonName { get; set; }

    // Other properties omitted for brevity
    [MaxLength(20)]
    public ClientStatus Status { get; set; }
}
