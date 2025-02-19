﻿using Application.Features.Users.Dtos;
using Application.Features.Users.Rules;
using Application.Services.AuthService;
using Application.Services.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Dtos;
using Core.Security.Hashing;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserDto>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly UserBusinessRules _userBusinessRules;
            private readonly IAuthService _authService;

            public LoginUserCommandHandler(IUserRepository userRepository,
                IMapper mapper,
                UserBusinessRules userBusinessRules, IAuthService authService)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _userBusinessRules = userBusinessRules;
                _authService = authService;
            }
            public async Task<LoginUserDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
            {
                var userToCheck = await _userRepository.GetAsync(u => u.Email == request.Email);
                if (userToCheck is null)
                {
                    throw new BusinessException("Kullanıcı bulunamadı");
                }

                if (!HashingHelper.VerifyPasswordHash(request.Password,
                    userToCheck.PasswordHash, userToCheck.PasswordSalt))
                {
                    throw new BusinessException("Şifre hatalı");
                }

                var accessToken = await _authService.CreateAccessToken(userToCheck);

                return new LoginUserDto
                {
                    AccessToken = accessToken
                };
            }
        }
    }
}
