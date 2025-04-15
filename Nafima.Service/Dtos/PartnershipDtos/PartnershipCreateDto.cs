using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.PartnershipDtos
{
    public class PartnershipCreateDto
    {
        public string Partner { get; set; }
        public IFormFile File { get; set; }
    }
}
