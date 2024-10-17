using apitest.Models;
using apiTest.Services.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest.Services.Profiles
{
    internal class TestsProfile : Profile
    {
        public TestsProfile()
        {
            CreateMap<TstMdl, TestsDto>();
        }
    }
}
