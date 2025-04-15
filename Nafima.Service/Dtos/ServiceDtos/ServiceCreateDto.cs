using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.ServiceDtos
{
    public class ServiceCreateDto
    {
        public string Icon { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
