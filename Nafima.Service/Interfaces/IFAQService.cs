using Nafima.Service.Dtos.FAQDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface IFAQService
    {
        int Create(FAQCreateDto createDto);
        List<FAQGetDto> GetAll();
    }
}
