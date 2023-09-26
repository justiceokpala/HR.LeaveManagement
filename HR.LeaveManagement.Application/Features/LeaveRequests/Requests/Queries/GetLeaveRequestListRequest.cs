using HR.LeaveManagement.Application.DTO_s.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest: IRequest<List<LeaveRequestDto>>
    {
    }
}
