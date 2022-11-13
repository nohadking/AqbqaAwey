using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeProvince
    {
        [Key]
        public Guid IdProvinces { get; set; }
        public string? ProvincesName { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
