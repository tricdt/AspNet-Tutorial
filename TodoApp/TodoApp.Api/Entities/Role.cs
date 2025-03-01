using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TodoApp.Api;

public class Role : IdentityRole<Guid>
{
    [MaxLength(250)]
    [Required]
    public virtual string? Description { get; set; }
}
