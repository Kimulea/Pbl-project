using Pbl.Domain.Auth;
using System;

namespace Pbl.Domain
{
    public class IdentityCard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
