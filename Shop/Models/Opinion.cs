using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Opinion
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [StringLength(100, ErrorMessage ="Zbyt długa nazwa")]
        public string User { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Treść jest wymagana")]
        [StringLength(5000, ErrorMessage = "Zbyt długa treść")]
        public string Message { get; set; }

        public bool NeedAnswer { get; set; }
    }
}
