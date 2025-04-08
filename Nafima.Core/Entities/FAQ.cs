using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class FAQ:AuditEntity
    {
        [MinLength(10)]
        public string Question  { get; set; }
        [MinLength(15)]

        public string Answer { get; set; }
    }
}
