using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Nafima.Core.Entities;
using Nafima.Data;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Dtos.SettingDtos;
using Nafima.Service.Exceptions;
using Nafima.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Implementations
{
    public class SettingService: ISettingService
    {
        private IMapper _mapper;
        private ISettingRepository _repository;
        private readonly AppDbContext _context;

        public SettingService(IMapper mapper, ISettingRepository repository, AppDbContext context)
        {
            _mapper = mapper;
            _repository = repository;
            _context = context;
        }
        public string Create(SettingCreateDto createDto)
        {
            if (_repository.Exists(x => x.Key == createDto.Key))
                throw new RestException(StatusCodes.Status400BadRequest, "Key", "Bu element artıq mövcuddur !");
            Setting entity = _mapper.Map<Setting>(createDto);
            _repository.Add(entity);
            _repository.Save();
            return entity.Key;
        }

        public List<SettingGetDto> GetAll()
        {
            var settings = _context.Settings.ToList();
            return _mapper.Map<List<SettingGetDto>>(settings);
        }


    }
}
