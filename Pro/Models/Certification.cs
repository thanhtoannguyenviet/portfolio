using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pro.Models
{
    public class Certification
    {
        [Key,Column(Order = 1)]
        public int  idcertification  { get; set; }
        public string namecertification { get; set; }
        public DateTime timeget { get; set; }

    }
}
