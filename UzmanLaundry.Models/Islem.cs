using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UzmanLaundry.Models
{
    public class Islem
    {
        public int ID { get; set; }

        [Required]
        public String islemTuru { get; set; }
    }
}
