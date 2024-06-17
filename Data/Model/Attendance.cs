using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Siga_Hrms.Data.Model;

public class Attendance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long AttendanceId { get; set; }

    [Required]
    public DateTime AttendanceDate { get; set; }

    [Required]
    public DateTime InTime { get; set; }

    public DateTime? OutTime { get; set; }

    public long EmployeeId { get; set; }

    public Employee Employee { get; set; }
}
