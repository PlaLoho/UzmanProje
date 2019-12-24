using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UzmanLaundry.Models
{
    public class Musteriler
    {
        public int ID { get; set; }
        [Required]
        public String firmaAdi { get; set; }
        public int islemID { get; set; }

        [ForeignKey("islemID")]
        public virtual Islem islem { get; set; }
    }
}
    