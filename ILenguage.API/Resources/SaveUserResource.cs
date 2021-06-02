using System.ComponentModel.DataAnnotations;
using ILenguage.API.Domain.Models;

namespace ILenguage.API.Resources
{
    public class SaveUserResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [MaxLength(245)]
        public string Description { get; set; }
        //TODO: User Suscription for save?

    }
}