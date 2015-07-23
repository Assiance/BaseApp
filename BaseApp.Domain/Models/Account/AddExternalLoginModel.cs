using System.ComponentModel.DataAnnotations;

namespace BaseApp.Domain.Models.Account
{
    public class AddExternalLoginModel
    {
        [Required]
        [Display(Name = "External access token")]
        public string ExternalAccessToken { get; set; }
    }
}