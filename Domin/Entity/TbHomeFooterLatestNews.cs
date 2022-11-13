using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeFooterLatestNews
    {
        [Key]
        public Guid IdlatestNews { get; set; }
        public string? TextArea { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEnyry { get; set; }
    }
}
