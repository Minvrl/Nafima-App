using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.ServiceDtos
{
    public class ServiceGetDto
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
