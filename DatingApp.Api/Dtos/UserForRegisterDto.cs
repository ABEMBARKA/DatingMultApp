namespace DatingApp.Api.Dtos
{
    using System.ComponentModel.DataAnnotations;

    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(100,MinimumLength = 4,ErrorMessage = "StringLenght")]
        public string Password { get; set; }
    }
}