using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Siga_Hrms.Data.Enum;

namespace Siga_Hrms.Data.Model;

public class Timesheet
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long TimesheetId { get; set; }
    
    [Required]
    public DateTime TimesheetDate { get; set; }

    [MaxLength(20)]
    public TimeSheetStatus TimesheetStatus { get; set; }

    public long? Approver { get; set; }

    public Employee ApproverEmployee { get; set; }

    [Required]
    public long EmployeeId { get; set; }

    public Employee Employee { get; set; }
}
