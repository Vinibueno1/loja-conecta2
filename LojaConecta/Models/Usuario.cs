using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace LojaConecta.Models;

public class Usuario : IdentityUser
{
    [Required]
    [StringLength(50)]
    public string Nome { get; set;}
    
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}
