using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} size must be between {2} and {1}!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Must be a valid Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(0.0, 5000.0, ErrorMessage = "{0} must be between {1} and {2}!")]
        public double BaseSalary { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(salesRecord => salesRecord.Date >= initial && salesRecord.Date <= final).Sum(salesRecord => salesRecord.Amount);
        }
    }
}
