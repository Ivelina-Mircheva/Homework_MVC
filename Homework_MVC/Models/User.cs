using System;
using System.Collections.Generic;

#nullable disable

namespace Homework_MVC.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
