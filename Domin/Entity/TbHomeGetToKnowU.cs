using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeGetToKnowU
    {
        [Key]
        public Guid IdGetToKnowUs { get; set; }
        public string? Title { get; set; } 
        public string? Description { get; set; }
        public string? Explanation { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntrey { get; set; }
    }
}
