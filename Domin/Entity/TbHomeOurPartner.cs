using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeOurPartner
    {
        [Key]
        public Guid IdOurPartners { get; set; }
        public string? CompanyName { get; set; }
        public string? Specialization { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Fax { get; set; }
        public string? Website { get; set; }
        public string? EMail { get; set; }
        public string? TheAddress { get; set; }
        public string? LogoImage { get; set; }
        public DateTime? EntryTimeAndDate { get; set; }
        public string? DataEntry { get; set; }
    }
}
