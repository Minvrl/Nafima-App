using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.FAQDtos
{
    public class FAQCreateDto
    {
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
