using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Admin")] //Tablo adını veriyoruz
    public class admin
    {
        [Key]  //Primary key olarak AdminID belirledik
        public int AdminID { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakter olmalıdır")]  // Eposta alanın zorunlu olduğunu, 50 karakter olması gerektiğini ve uyarı mesajı verdik
        public string Eposta { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakter olmalıdır")]
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    }
}