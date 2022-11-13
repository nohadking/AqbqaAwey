using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomePhotoGalleryTrip
    {
        [Key]
        public Guid IdPhotoGalleryTrips { get; set; }
        public int? IDtripsSchedule { get; set; }
        public string? PictureName { get; set; }
        public string? VideoName { get; set; }
        public string? Description { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
