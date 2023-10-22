using System.ComponentModel.DataAnnotations;


namespace DrMediScanV6.Models.ViewModels
{
    public class Patient
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone number can only contain digits.")]
        public string PhoneNo { get; set; }
    }
}
