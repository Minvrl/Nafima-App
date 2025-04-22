using AutoMapper;
using Microsoft.AspNetCore.Http;
using Nafima.Core.Entities;
using Nafima.Data;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Dtos.DonationDtos;
using Nafima.Service.Dtos.PartnershipDtos;
using Nafima.Service.Exceptions;
using Nafima.Service.Extensions;
using Nafima.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Implementations
{
    public class PartnershipService: IPartnershipService
    {
        private IMapper _mapper;
        private IPartnershipRepository _repository;
        private readonly AppDbContext _context;


        public PartnershipService(IMapper mapper, IPartnershipRepository repository, AppDbContext context)
        {
            _mapper = mapper;
            _repository = repository;
            _context = context;
        }

        public int Create(PartnershipCreateDto createDto)
        {
            Partnership entity = new Partnership
            {
                Partner = createDto.Partner,
                FileName = createDto.File.Save("uploads/partner")
            };

            _context.Partners.Add(entity);
            _context.SaveChanges();

            return entity.Id;
        }

        public List<PartnershipGetDto> GetAll()
        {
            return _mapper.Map<List<PartnershipGetDto>>(_repository.GetAll(x => !x.IsDeleted).ToList());
        }
    }
}
