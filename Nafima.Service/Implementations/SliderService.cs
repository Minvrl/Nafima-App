using AutoMapper;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Data;
using Nafima.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nafima.Core.Entities;
using Nafima.Service.Dtos.PartnershipDtos;
using Nafima.Service.Dtos.SliderDtos;
using Nafima.Service.Extensions;

namespace Nafima.Service.Implementations
{
    public class SliderService: ISliderService
    {
        private IMapper _mapper;
        private ISliderRepository _repository;
        private readonly AppDbContext _context;


        public SliderService(IMapper mapper, ISliderRepository repository, AppDbContext context)
        {
            _mapper = mapper;
            _repository = repository;
            _context = context;
        }
        public int Create(SliderCreateDto createDto)
        {
            Slider entity = new Slider
            {
                PrimaryText = createDto.PrimaryText,
                SecondaryText = createDto.SecondaryText,
                Current = createDto.Current,
                Image = createDto.File.Save("uploads/slider")
            };

            _context.Sliders.Add(entity);
            _context.SaveChanges();

            return entity.Id;
        }

        public List<SliderGetDto> GetAll()
        {
            return _mapper.Map<List<SliderGetDto>>(_repository.GetAll(x => !x.IsDeleted).ToList());
        }
    }
}
