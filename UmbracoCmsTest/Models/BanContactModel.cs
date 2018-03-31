using System.ComponentModel.DataAnnotations;

namespace UmbracoCmsTest.Models
{
    public class BanContactModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}