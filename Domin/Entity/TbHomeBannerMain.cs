using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeBannerMain
    {
        [Key]
        public Guid IdBannerMain { get; set; }
        public string? VideoTrack { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntrey { get; set; }
    }
}
