﻿using Application.Features.Cars.Commands.EndRentalCarInfo;
using Application.Features.Cars.Commands.UpdateCarState;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Rules
{
    public class CarBusinessRules
    {
        ICarRepository _carRepository;
         IMediator _mediator;

        public CarBusinessRules(ICarRepository carRepository, IMediator mediator )
        {
            _carRepository = carRepository;
            _mediator = mediator;
        }
        public async Task<Car> CheckIfCarIsExist(int carId)
        {
            var result = await _carRepository.GetAsync(c => c.Id == carId);
            if (result == null)
            {
                throw new BusinessException("Araba bulunamadı");
            }
            return result;
           
        }
        public async Task CheckIfCarIsRented(int carId)
        {
            var car = await _carRepository.GetAsync(c => c.Id == carId);
            if (car.CarState == CarState.Rented)
            {
                throw new BusinessException("Araba Kirada");
            }
        }
        public async Task CheckIfCarIsMaintenance(int carId)
        {
            var car = await _carRepository.GetAsync(c => c.Id == carId);
            if (car.CarState == CarState.Maintenance)
            {
                throw new BusinessException("Araba Bakımda");
            }
        }
        public async Task CheckIfPlateCanNotBeDuplicated(string plate)
        {
            var result = await _carRepository.GetListAsync(c => c.Plate==plate);
            if (result.Items.Any())
            {
                throw new BusinessException("Plaka bulunamadı");
            }
        }
        public async Task<int> GetFindexScoreById(int id)
        {
            var result = await _carRepository.GetAsync(c => c.Id == id);
            if (result is null)
            {
                throw new BusinessException("Araba Bulunamadı");
            }
            return result.FindexScore;
        }
        public async Task UpdateCarState(UpdateCarStateCommand updateCarStateCommand)
        {
            var result = await _mediator.Send(updateCarStateCommand);

            if (result == null)
            {
                throw new BusinessException("Araba müsaitliği güncellenirken hata");
            }

        }
        public async Task UpdateCarKilometerCityInfo(EndRentalCarInfoCommand endRentalCarInfo)
        {
            var result = await _mediator.Send(endRentalCarInfo);

            if (result == null)
            {
                throw new BusinessException("Araba kilometre ve şehir biligisi güncellenirken hata");
            }

        }
    }
}
