using Nafima.Service.Dtos.PartnershipDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface IPartnershipService
    {
        int Create(PartnershipCreateDto createDto);
        List<PartnershipGetDto> GetAll();
    }
}
