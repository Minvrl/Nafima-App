using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class Partnership:AuditEntity
    {
        public string Partner {  get; set; }
        public string FileName { get; set; }

    }
}
