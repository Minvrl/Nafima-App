using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Core.Entities
{
    public class Review: AuditEntity
    {
        [MinLength(10)]
        public string Text { get; set; }
        public bool IsAnon { get; set; }  
        public string? Name { get; set; }
        [MinLength(5)]
        [MaxLength(40)]

        public string Position { get; set; }
        

    }
}
