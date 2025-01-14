﻿using System.ComponentModel.DataAnnotations;

namespace BlogAsp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public enum SortState
    {
        LoginAsc,
        LoginDesc,
        EmailAsc,
        EmailDesc,
    }
}