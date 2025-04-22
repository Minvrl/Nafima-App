using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Dtos.SettingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface ISettingService
    {
        string Create(SettingCreateDto createDto);
        List<SettingGetDto> GetAll();
    }
}
