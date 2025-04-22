using Nafima.Service.Dtos.StatisticDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface IStatisticService
    {
        int Create(StatisticCreateDto createDto);
        List<StatisticGetDto> GetAll();
    }
}
