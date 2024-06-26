﻿using System.ComponentModel.DataAnnotations;

namespace CORECRUD.Models
{
	public class User
	{
		[Key]
        public int ID { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; } //1 ise admin,0 user
	}
}
