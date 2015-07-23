using System.ComponentModel.DataAnnotations;

namespace BaseApp.Domain.Models.Account
{
    public class RegisterExternalModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}