using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class EmployeeDesignation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long EmployeeDesignationId { get; set; }

    [Required]
    public DateTime FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public long EmployeeId { get; set; }

    public Employee Employee { get; set; }

    public int DesignationId { get; set; }

    public Designation Designation { get; set; }
}
