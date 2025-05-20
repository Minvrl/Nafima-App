using AutoMapper;
using Microsoft.AspNetCore.Http;
using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Dtos.DonationDtos;
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
    public class DonationService : IDonationService
    {
        private IMapper _mapper;
        private IDonationRepository _repository;

        public DonationService(IMapper mapper, IDonationRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public int Create(DonationCreateDto createDto)
        {
          
            Donation entity = _mapper.Map<Donation>(createDto);
            _repository.Add(entity);
            _repository.Save();
            return entity.Id;
        }

        public List<DonationGetDto> GetAll()
        {
            return _mapper.Map<List<DonationGetDto>>(_repository.GetAll(x => !x.IsDeleted).ToList());
        }
        public void Delete(int id)
        {
            Donation entity = _repository.Get(x => x.Id == id && !x.IsDeleted);

            if (entity == null) throw new RestException(StatusCodes.Status404NotFound, "Donation not found");

            entity.IsDeleted = true;
            entity.ModifiedAt = DateTime.Now;
            _repository.Save();
        }

    }
}
