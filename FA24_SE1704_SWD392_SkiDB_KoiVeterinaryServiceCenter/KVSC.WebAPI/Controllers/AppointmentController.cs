using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // POST: api/appointment/service
        [HttpPost("service")]
        public async Task<IResult> MakeAppointmentForService([FromBody] MakeAppointmentForServiceRequest request)
        {
            Result result = await _appointmentService.MakeAppointmentForServiceAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Appointment for service created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // POST: api/appointment/combo
        [HttpPost("combo")]
        public async Task<IResult> MakeAppointmentForCombo([FromBody] MakeAppointmentForComboRequest request)
        {
            Result result = await _appointmentService.MakeAppointmentForComboAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Appointment for combo created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
