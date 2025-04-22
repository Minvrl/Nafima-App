using AutoMapper;
using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Dtos.DonationDtos;
using Nafima.Service.Dtos.ReviewDtos;
using Nafima.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Implementations
{
    public class ReviewService: IReviewService
    {
        private IMapper _mapper;
        private IReviewRepository _repository;

        public ReviewService(IMapper mapper, IReviewRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public int Create(ReviewCreateDto createDto)
        {

            Review entity = _mapper.Map<Review>(createDto);
            _repository.Add(entity);
            _repository.Save();
            return entity.Id;
        }

        public List<ReviewGetDto> GetAll()
        {
            return _mapper.Map<List<ReviewGetDto>>(_repository.GetAll(x => !x.IsDeleted).ToList());
        }
    }
}
