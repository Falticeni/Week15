using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Users.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Category CategoryId { get; set; }
        public enum Category
        {
            A,
            B,
            C
        }
    }
}