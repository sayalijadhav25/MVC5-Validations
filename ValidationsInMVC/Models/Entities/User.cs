﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationsInMVC.Models.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FacebookProfileURL { get; set; }
    }
}