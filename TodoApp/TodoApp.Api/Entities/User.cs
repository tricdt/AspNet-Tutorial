using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TodoApp.Api;

public class User : IdentityUser<Guid>
{
    [MaxLength(250)]
    [Required]
    public virtual string? FirstName { get; set; }

    [MaxLength(250)]
    [Required]
    public virtual string? LastName { get; set; }

    [Column(TypeName = "nvarchar")]
    [StringLength(400)]
    public virtual string? HomeAdress { get; set; }

    // [Required]       
    [DataType(DataType.Date)]
    public virtual DateTime? BirthDate { get; set; }
}
