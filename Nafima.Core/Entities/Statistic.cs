using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class Statistic:AuditEntity
    {
        public int Number {  get; set; }
        public string Text { get; set; }
    }
}
