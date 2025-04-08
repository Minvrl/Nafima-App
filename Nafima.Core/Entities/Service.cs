using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class Service:AuditEntity
    {
        public string Icon { get; set; }
        [MinLength(5)]
        [MaxLength(30)]
        public string Title { get; set; }
        [MinLength(20)]

        public string Description { get; set; }
    }
}
