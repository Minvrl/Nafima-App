using Nafima.Service.Dtos.DonationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface IDonationService
    {
        int Create(DonationCreateDto createDto);
        List<DonationGetDto> GetAll();
    }
}
