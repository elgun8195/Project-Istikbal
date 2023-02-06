using System.ComponentModel.DataAnnotations;

namespace Istikbal_Backend.ViewModels
{
    public class RegisterVM
    {
        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(200)]
        public string Username { get; set; }
        [Required, StringLength(200)]
        public string Surname { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string CheckPassword { get; set; }
    }
}
