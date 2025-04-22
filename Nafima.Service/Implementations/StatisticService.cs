using AutoMapper;
using Microsoft.AspNetCore.Http;
using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Dtos.StatisticDtos;
using Nafima.Service.Exceptions;
using Nafima.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Implementations
{
    public class StatisticService: IStatisticService
    {
        private IMapper _mapper;
        private IStatisticRepository _repository;
        public StatisticService(IMapper mapper, IStatisticRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public int Create(StatisticCreateDto createDto)
        {
            if (_repository.Exists(x => x.Text == createDto.Text && !x.IsDeleted))
                throw new RestException(StatusCodes.Status400BadRequest, "Text", "Bu statistika artıq movcuddur !");
            Statistic entity = _mapper.Map<Statistic>(createDto);
            _repository.Add(entity);
            _repository.Save();
            return entity.Id;
        }

        public List<StatisticGetDto> GetAll()
        {
            return _mapper.Map<List<StatisticGetDto>>(_repository.GetAll(x => !x.IsDeleted).ToList());
        }
    }
}
