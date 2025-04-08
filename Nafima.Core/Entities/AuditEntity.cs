using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class AuditEntity: BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
