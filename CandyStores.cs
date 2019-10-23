using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy3.Data
{
    public class CandyStores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CName { get; set; }
        public string Ctype { get; set; }
        public int CPrice { get; set; }
        public int Csize { get; set; }
    }
}
