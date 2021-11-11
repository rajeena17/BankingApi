using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApi.Data
{
    public class Bank
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int AdminID { get; set; }
        public int ACC_NO { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Account_Holder_Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Mobile_Number { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Country { get; set; }

        [Required]
        public float Amount { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
