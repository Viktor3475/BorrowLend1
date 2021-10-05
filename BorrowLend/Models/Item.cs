using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Models
{
    public class Item
    {
        [Key]
        public int Id { set; get; }
        
        [Display(Name = "Item name")] [Required]
        public string ItemName { set; get; }

        [Required]
        public string Borrower { set; get; }

        [Required]
        public string Lender { set; get; }
    }
}
