using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public Guid CustomerId { get; set; } 
        public Guid? PetId { get; set; } 
        public Guid? PetServiceId { get; set; } 
        public Guid? ComboServiceId { get; set; } 
        public DateTime AppointmentDate { get; set; } // Date and time of the appointment
        public string Status { get; set; } // Appointment status: Pending, Accepted, Rejected, Cancelled
        public DateTime? AcceptedDate { get; set; } // Date the appointment was accepted
        public DateTime? CompletedDate { get; set; } // Date the appointment was completed 

        // Navigation properties
        public User Customer { get; set; } 
        public Pet Pet { get; set; }
        public PetService PetService { get; set; } 
        public ComboService ComboService { get; set; }

        // Many-to-many relationship with Veterinarian
        public ICollection<AppointmentVeterinarian> AppointmentVeterinarians { get; set; }
    }
}
