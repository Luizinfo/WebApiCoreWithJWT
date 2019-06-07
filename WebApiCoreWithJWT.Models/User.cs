using System;

namespace WebApiCoreWithJWT.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public string CompanyId { get; set; }

        public string Token { get; set; }
        public DateTime TokenExpiration { get; set; }

        public Role Role { get; set; }
        public Company Company { get; set; }
    }
}
