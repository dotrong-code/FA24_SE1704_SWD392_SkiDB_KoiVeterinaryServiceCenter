using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class VeterinarianSchedule : BaseEntity
    {
        public Guid VeterinarianId { get; set; } // Liên kết đến bác sĩ thú y
        public DateTime Date { get; set; } 
        public TimeSpan StartTime { get; set; } 
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; } // Trạng thái có sẵn xem là có appointment chưa

        // Navigation property
        public Veterinarian Veterinarian { get; set; } // Quan hệ với Veterinarian
    }
}
