using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Domain.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }    
    }
}