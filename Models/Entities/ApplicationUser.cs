using System;
using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public DateTime DateCreated { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}