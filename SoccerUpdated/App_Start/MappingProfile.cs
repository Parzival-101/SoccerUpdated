using AutoMapper;
using SoccerUpdated.Dto;
using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerUpdated.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Players, PlayerDto>();
            Mapper.CreateMap<PlayerDto, Players>();
            Mapper.CreateMap<Club, ClubDto>();
            Mapper.CreateMap<ClubDto, Club>();

           
        }
    }
}