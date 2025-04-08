using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class Slider: AuditEntity
    {
        [MinLength(10)]
        [MaxLength(80)]
        public string PrimaryText { get; set; }
        [MinLength(10)]
        [MaxLength(100)]
        public string SecondaryText { get; set; }
        public string Image { get; set; }
        public bool Current { get; set; }
    }
}
