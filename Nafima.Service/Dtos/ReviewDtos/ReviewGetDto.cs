using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.ReviewDtos
{
    public class ReviewGetDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsAnon { get; set; }
        public string? Name { get; set; }

        public string Position { get; set; }
    }
}
