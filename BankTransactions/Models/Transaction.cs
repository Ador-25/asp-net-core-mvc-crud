using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        
        [MaxLength(12,ErrorMessage ="Maximum length is 12 characters")]  
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This field is required")]
        public string AccountNumber { get; set; }

        [DisplayName("Beneficiary Name")]
        [Column(TypeName="nvarchar(100)")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }

        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }

        [DisplayName("SWIFT Code")]
        [MaxLength(11, ErrorMessage = "Maximum length is 11 characters")]
        [Required(ErrorMessage = "This field is required")]
        public string SWIFTCode { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy HH:mm:ss}")]
        public DateTime Date { get; set; }
    }
}
