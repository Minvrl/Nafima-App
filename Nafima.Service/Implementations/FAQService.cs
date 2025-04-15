using AutoMapper;
using Microsoft.AspNetCore.Http;
using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Exceptions;
using Nafima.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Implementations
{
    public class FAQService: IFAQService
    {
        private IMapper _mapper;
        private IFAQRepository _repository;
        public FAQService(IMapper mapper, IFAQRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public int Create(FAQCreateDto createDto)
        {
            if (_repository.Exists(x => x.Question == createDto.Question && !x.IsDeleted))
                throw new RestException(StatusCodes.Status400BadRequest, "Question", "Bu sual artıq cavablanıb !");
            FAQ entity = _mapper.Map<FAQ>(createDto);
            _repository.Add(entity);
            _repository.Save();
            return entity.Id;
        }

        public List<FAQGetDto> GetAll()
        {
            return _mapper.Map<List<FAQGetDto>>(_repository.GetAll(x => !x.IsDeleted).ToList());
        }
    }
}
