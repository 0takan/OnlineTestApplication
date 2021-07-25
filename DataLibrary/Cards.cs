using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLibrary
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
