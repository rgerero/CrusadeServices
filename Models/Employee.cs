using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CrusadeServices.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Department { get; set; }
        public string SalesPersonId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastMOdified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
