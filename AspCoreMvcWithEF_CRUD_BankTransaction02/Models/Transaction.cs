using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspCoreMvcWithEF_CRUD_BankTransaction02.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This is Mandatory Field")]
        [MaxLength(12,ErrorMessage ="Maximum 12 charecter only")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarcha(100")]
        [DisplayName("Beneficiary Name")]
        [Required]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarcha(100")]
        [Required]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar9(11)")]
        [DisplayName("SWIFT Code")]
        public string SWIFTCode { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:MM-dd-yy}")]
        public DateTime Date { get; set; }


    }
}
