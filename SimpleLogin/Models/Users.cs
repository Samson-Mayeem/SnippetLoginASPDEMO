using System.ComponentModel.DataAnnotations;

namespace SimpleLogin.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string ?UserName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string ?Password { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        public string ?Role { get; set; }
        public string ?ConfirmPassword { get; set; }
        public bool Enabled { get; set; }
    }
}
