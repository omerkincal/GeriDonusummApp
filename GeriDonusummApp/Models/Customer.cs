using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeriDonusummApp.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "İsminizi giriniz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Emailinizi giriniz!")]
        [EmailAddress(ErrorMessage = "Emailinizi giriniz!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı giriniz!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Kayıt olup olmadığınızı bilmemiz gerekmekte.")]
        public bool? WillAttend { get; set; }
    }
}
