using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TbHomeBuckectListsDescription
    {
        [Key]
        public Guid IdBuckectLists { get; set; }
        public string? BuckectListsDescription { get; set; }
        public DateTime? Entrytimeanddate { get; set; }
        public string? DtatEntry { get; set; }
    }
}
