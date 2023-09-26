using HR.LeaveManagement.Application.DTO_s;
using HR.LeaveManagement.Application.DTO_s.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand: IRequest<int>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }

    }
}
