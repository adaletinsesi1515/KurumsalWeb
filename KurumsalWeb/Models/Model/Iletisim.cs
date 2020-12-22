using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWeb.Models.Model
{
    [Table("Iletisim")]
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Adres { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Telefon { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Faks { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Whatsapp { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Facebook { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Twitter { get; set; }

        [StringLength(250, ErrorMessage = "250 karakter olmalıdır")]
        public string Instagram { get; set; }
    }
}