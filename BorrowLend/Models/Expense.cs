using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class Expense
    {

        [Key]
        public int Id { set; get; }

        [Required]
        [Display(Name = "Expense name")]
        public string ExpenseName { set; get; }

        [Required]
        [Range(1,double.MaxValue, ErrorMessage = "The amount must be positive number")]
        public double Amount { set; get; }
        public int ExpenseTypeId { set; get; }
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { set; get; }
    }
}
