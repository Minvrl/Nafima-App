using Nafima.Service.Dtos.ReviewDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Interfaces
{
    public interface IReviewService
    {
        int Create(ReviewCreateDto createDto);
        List<ReviewGetDto> GetAll();    
    }
}
