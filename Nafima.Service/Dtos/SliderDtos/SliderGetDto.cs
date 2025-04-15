using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.SliderDtos
{
    public class SliderGetDto
    {
        public int Id { get; set; }
        public string PrimaryText { get; set; }
        public bool Current { get; set; }
        public string SecondaryText { get; set; }
        public string ImageUrl { get; set; }
    }
}
