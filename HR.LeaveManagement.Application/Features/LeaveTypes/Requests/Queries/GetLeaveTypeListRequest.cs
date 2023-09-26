using HR.LeaveManagement.Application.DTO_s;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest :IRequest<List<LeaveTypeDto>>
    {
    }
}
