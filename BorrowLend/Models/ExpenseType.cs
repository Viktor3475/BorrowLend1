using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { set; get; }

        [Required]
        public string ExpenseTypeName { set; get; }
    }
}
