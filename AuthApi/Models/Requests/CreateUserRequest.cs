using System.ComponentModel.DataAnnotations;

namespace AuthApi.Models.Requests
{
    public class CreateUserRequest
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
