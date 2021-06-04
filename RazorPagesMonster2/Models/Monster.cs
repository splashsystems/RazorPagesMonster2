using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMonster2.Models
{
    public class Monster
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string MonsterName { get; set; }
        [Display(Name = "Origin Date")]
        [DataType(DataType.Date)]
        public DateTime OriginDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
