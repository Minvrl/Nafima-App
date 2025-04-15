using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.FAQDtos
{
    public class FAQGetDto
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public string Answer { get; set; }

    }
}
