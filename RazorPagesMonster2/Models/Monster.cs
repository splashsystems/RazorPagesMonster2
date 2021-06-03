using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMonster2.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string MonsterName { get; set; }
        [DataType(DataType.Date)]
        public DateTime OriginDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
