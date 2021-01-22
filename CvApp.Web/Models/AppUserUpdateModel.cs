using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CvApp.Web.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı gereklidir.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Adres alanı gereklidir.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Email alanı gereklidir.")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Telefon alanı gereklidir.")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Ön yazı alanı gereklidir.")]
        public string ShortDescription { get; set; }
        public IFormFile Picture { get; set; }
    }
}
