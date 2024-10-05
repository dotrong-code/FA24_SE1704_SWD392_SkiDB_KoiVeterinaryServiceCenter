using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class AppointmentVeterinarian : BaseEntity
    {
        public Guid AppointmentId { get; set; }
        public Guid VeterinarianId { get; set; }

        // Navigation properties
        public Appointment Appointment { get; set; }
        public User Veterinarian { get; set; } 
    }
}
