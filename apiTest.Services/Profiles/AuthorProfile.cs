using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apiTest.Models;
using apiTest.Services.ViewModels;
using AutoMapper;

namespace apiTest.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                //projection part(Map data from source to destination)
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.Address},{src.Street},{src.City}"));
        }
    }
}
