﻿using FluentValidation;
using HomeApi.Contracts.Models.Rooms;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов на обновление комнаты
    /// </summary>
    public class UpdateRoomRequestValidator : AbstractValidator<UpdateRoomRequest>
    {
        public UpdateRoomRequestValidator() 
        {
            //RuleFor(x => x.NewName).NotEmpty();
            //RuleFor(x => x.NewArea).NotEmpty();
            //RuleFor(x => x.NewVoltage).NotEmpty();
            //RuleFor(x => x.NewGasConnected).NotEmpty();
        }
    }
}