using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Service.Dtos.SliderDtos
{
    public class SliderCreateDto
    {
        public string PrimaryText { get; set; }
        public string SecondaryText { get; set; }
        public IFormFile File { get; set; }
        public bool Current { get; set; }
    }
    public class SliderCreateDtoValidator : AbstractValidator<SliderCreateDto>
    {
        public SliderCreateDtoValidator()
        {
            RuleFor(x => x.PrimaryText)
                .NotEmpty().MaximumLength(35).MinimumLength(5);
            RuleFor(x => x).Custom((f, c) =>
            {
                if (f.File != null && f.File.Length > 2 * 1024 * 1024)
                {
                    c.AddFailure("File", "File must be less or equal than 2MB");
                }
            });

        }
    }
}
