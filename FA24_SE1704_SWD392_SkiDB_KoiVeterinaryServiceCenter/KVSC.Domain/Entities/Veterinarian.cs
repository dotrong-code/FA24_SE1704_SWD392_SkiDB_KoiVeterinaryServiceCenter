using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Veterinarian : BaseEntity
    {
        public Guid UserId { get; set; } 

        public string LicenseNumber { get; set; } // Số giấy phép hành nghề
        public string Specialty { get; set; } // Chuyên môn
        public decimal ConsultationFee { get; set; } // Phí tư vấn
        public string Qualifications { get; set; } // Học vị/chứng chỉ


        // Navigation properties
        public User User { get; set; } // Quan hệ với User
        public ICollection<VeterinarianSchedule> VeterinarianSchedules { get; set; } // Quan hệ với VeterinarianSchedule
    }
}
