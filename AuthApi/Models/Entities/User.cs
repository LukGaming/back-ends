using System.ComponentModel.DataAnnotations;

namespace AuthApi.Models.Entities
{
    public class User
    {
            
            public int Id { get; set; }

            public string name { get; set; }

            public string email { get; set; }

            public string password { get; set; }

    }
}
