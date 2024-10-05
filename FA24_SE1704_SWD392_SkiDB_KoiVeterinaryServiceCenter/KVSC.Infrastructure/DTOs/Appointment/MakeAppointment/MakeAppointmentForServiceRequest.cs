using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.MakeAppointment
{
    public class MakeAppointmentForServiceRequest
    {
        public Guid CustomerId { get; set; }
        public Guid PetId { get; set; }
        public Guid PetServiceId { get; set; }
        public List<Guid> VeterinarianIds { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
