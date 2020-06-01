﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
namespace CBA.Training.Talmate.EntityModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }        
        //public string Token { get; set; }
    }
}