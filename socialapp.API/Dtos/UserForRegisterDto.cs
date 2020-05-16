using System.ComponentModel.DataAnnotations;

namespace socialapp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    


        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="error")]
        public string Password { get; set; }    

    }
}