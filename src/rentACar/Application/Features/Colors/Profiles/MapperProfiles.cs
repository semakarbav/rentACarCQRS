﻿using Application.Features.Colors.Commands.CreateColor;
using Application.Features.Colors.Commands.DeleteColor;
using Application.Features.Colors.Commands.UpdateColor;
using Application.Features.Colors.Dtos;
using Application.Features.Colors.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Colors.Profiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Color, CreateColorCommand>().ReverseMap();
            CreateMap<Color, UpdateColorCommand>().ReverseMap();
            CreateMap<Color, DeleteColorCommand>().ReverseMap();
            CreateMap<Color, ColorListDto>().ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<Color, CreatedColorDto>().ReverseMap();
            CreateMap<Color, DeletedColorDto>().ReverseMap();
            CreateMap<Color, UpdatedColorDto>().ReverseMap();
            CreateMap<IPaginate<Color>, ColorListModel>().ReverseMap();

        }
    }
}
