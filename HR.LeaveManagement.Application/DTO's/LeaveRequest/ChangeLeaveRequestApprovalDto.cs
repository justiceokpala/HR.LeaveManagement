using HR.LeaveManagement.Application.DTO_s.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTO_s.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto :BaseDto
    {
        public bool? Approved { get; set; }

    }
}
