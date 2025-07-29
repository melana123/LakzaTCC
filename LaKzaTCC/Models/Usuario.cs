using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace LaKzaTCC.Models;

    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage ="Por favor, informe o nome")]
        public string Nome { get; set; }
    }
