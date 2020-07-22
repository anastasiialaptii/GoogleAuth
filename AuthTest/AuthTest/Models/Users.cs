using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models
{
    public class User
    {
        public string email { get; set; }
        [Key]
        
        public string id { get; set; }

        public string idToken { get; set; }

        public string image { get; set; }
        
        public string name { get; set; }

        public string provider { get; set; }

        public string token { get; set; }

    }
}

