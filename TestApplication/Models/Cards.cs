using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Cards
    {
        public int CardsId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string test_name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string img { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string descrition { get; set; }
    }
}
