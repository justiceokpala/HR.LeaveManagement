﻿using FluentValidation;
using HR.LeaveManagement.Application.DTOs.LeaveType.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTO_s.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator: AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());


        }
    }
}
