using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbSeRatingDatum
    {
        [Key]
        public Guid IdRatingData { get; set; }
        public Guid IDtripsSchedule { get; set; }
        [ForeignKey("IDtripsSchedule")]
        public TbHomeDtripsSchedule TbHomeDtripsSchedule  { get; set; }
        public string? NameClint { get; set; }
        public string? MailClint { get; set; }
        public string? Views { get; set; }
        public string? Evaluation { get; set; }
        public string? userEmail { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
