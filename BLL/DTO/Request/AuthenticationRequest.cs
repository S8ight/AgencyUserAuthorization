﻿using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Request;

public class AuthenticationRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}