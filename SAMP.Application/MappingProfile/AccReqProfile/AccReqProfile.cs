using Ardalis.Result;
using AutoMapper;
using SAMP.Application.DTOs.AccReqDto;
using SAMP.Domain.Entities;
using System;

namespace SAMP.Application.MappingProfile.AccReqProfile
{
    internal class AccReqProfile : Profile
    {
        public AccReqProfile()
        {
            CreateMap<AccReqCreateDto, AccReq>().ReverseMap();

            CreateMap<AccReq, AccReqResponseDto>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
                .ForMember(dest => dest.StateName, opt => opt.MapFrom(src => src.City.State.Name))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.City.State.Country.Name))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.Name))
                .ForMember(dest => dest.TransportMode, opt => opt.MapFrom(src => src.ReqTransMode.Name)).ReverseMap();

            CreateMap<AccReqCreateDto, AccReq>()
                .ForMember(dest => dest.ExpCheckInTime, opt => opt.MapFrom(src => DateTime.Parse(src.ExpCheckInTime)))
                .ForMember(dest => dest.ExpCheckOutTime, opt => opt.MapFrom(src => DateTime.Parse(src.ExpCheckOutTime)));

            CreateMap<AccReq, AccReqUpdateDto>();

        }
    }
}
