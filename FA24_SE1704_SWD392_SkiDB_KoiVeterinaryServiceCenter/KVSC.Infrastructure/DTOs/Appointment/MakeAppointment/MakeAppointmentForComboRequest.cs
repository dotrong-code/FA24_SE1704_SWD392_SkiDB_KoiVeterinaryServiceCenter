using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.MakeAppointment
{
    public class MakeAppointmentForComboRequest
    {
        public Guid CustomerId { get; set; }
        public Guid PetId { get; set; }
        public Guid ComboServiceId { get; set; }
        public List<Guid> VeterinarianIds { get; set; }
    }
}
