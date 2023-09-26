using HR.LeaveManagement.Application.DTO_s;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest: IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
