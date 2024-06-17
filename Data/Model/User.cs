using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Siga_Hrms.Data.Model;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long UserId { get; set; }

    [Required]
    [MaxLength(50)]
    public string UserName { get; set; }

    [Required]
    public string PasswordPhrase { get; set; }

    [Required]
    public string PasswordSalt { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDateTime { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedDateTime { get; set; }
}


