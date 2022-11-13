using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeVedogallery
    {
        [Key]
        public Guid Idvedogallery { get; set; }
        public Guid IDtripsSchedule { get; set; }
        [ForeignKey("IDtripsSchedule")]
        public TbHomeDtripsSchedule tbHomeDtripsSchedule  { get; set; }
        public string? Vidoname { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
