using Nafima.Core.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Nafima.Service.Dtos.DonationDtos;
using Nafima.Service.Dtos.FAQDtos;
using Nafima.Service.Dtos.PartnershipDtos;
using Nafima.Service.Dtos.ReviewDtos;
using Nafima.Service.Dtos.ServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nafima.Service.Dtos.SettingDtos;
using Nafima.Service.Dtos.StatisticDtos;
using Nafima.Service.Dtos.SliderDtos;

namespace Nafima.Service.Profiles
{
    public class MapProfile : Profile
    {
        private readonly IHttpContextAccessor _context;

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {
            _context = httpContextAccessor;
            var uriBuilder = new UriBuilder(_context.HttpContext.Request.Scheme, _context.HttpContext.Request.Host.Host, _context.HttpContext.Request.Host.Port ?? -1);
            if (uriBuilder.Uri.IsDefaultPort)
            {
                uriBuilder.Port = -1;
            }
            string baseUrl = uriBuilder.Uri.AbsoluteUri;

            //FAQ
            CreateMap<FAQ, FAQGetDto>();
            CreateMap<FAQCreateDto, FAQ>();

            //Donation
            CreateMap<Donation, DonationGetDto>();
            CreateMap<DonationCreateDto, Donation>();

            //Partnership
            CreateMap<Partnership, PartnershipGetDto>()
                .ForMember(dest => dest.ImageUrl, s => s.MapFrom(s => baseUrl + "uploads/partner/" + s.FileName));

            //Review
            CreateMap<Review, ReviewGetDto>();
            CreateMap<ReviewCreateDto, Review>();

            //Service
            //CreateMap<Service, ServiceGetDto>();
            //CreateMap<ServiceCreateDto, Service>

            //Setting
            CreateMap<SettingCreateDto, Setting>();
            CreateMap<Setting, SettingGetDto>();

            //Slider
            CreateMap<Slider, SliderGetDto>()
                .ForMember(dest => dest.ImageUrl, s => s.MapFrom(s => baseUrl + "uploads/slider/" + s.Image));
            CreateMap<SliderCreateDto, Slider>();

            //Statistic
            CreateMap<Statistic, StatisticGetDto>();
            CreateMap<StatisticCreateDto, Statistic>();
        }


    }
}
