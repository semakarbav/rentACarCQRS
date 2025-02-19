﻿using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using Application.Features.Brands.Models;
using Application.Features.Maintenenaces.Commands.CreateMaintenance;
using Application.Features.Rentals.Commands.CreateRental;
using Application.Features.Rentals.Commands.CreateRental.CreateEndRentalForCorporateCustomer;
using Application.Features.Rentals.Commands.CreateRental.CreateEndRentalForIndividualCustomer;
using Application.Features.Rentals.Commands.CreateRental.CreateRentalForCorporateCustomer;
using Application.Features.Rentals.Commands.DeleteRental;
using Application.Features.Rentals.Commands.UpdateRental;
using Application.Features.Rentals.Dtos;
using Application.Features.Rentals.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rentals.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
           
            CreateMap<Rental, RentForIndividualCustomerCommand>().ReverseMap();
            CreateMap<Rental, RentForCorporateCustomerCommand>().ReverseMap();
            CreateMap<Rental, CreateEndRentalCommandForCorporateCommand>().ReverseMap();
            CreateMap<Rental, CreateEndRentalCommandForIndividualCommand>().ReverseMap();
            CreateMap<Rental, UpdateRentalCommand>().ReverseMap();
            CreateMap<Rental, DeleteRentalCommand>().ReverseMap();
            CreateMap<Rental, CreatedRentalDto>().ReverseMap();
            CreateMap<Rental, RentalListDto>().ReverseMap();
            CreateMap<IPaginate<Rental>, RentalListModel>().ReverseMap();
        }
    }
}
