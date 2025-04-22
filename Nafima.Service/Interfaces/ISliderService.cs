using Nafima.Service.Dtos.SliderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface ISliderService
    {
        int Create(SliderCreateDto createDto);
        List<SliderGetDto> GetAll();
    }
}
