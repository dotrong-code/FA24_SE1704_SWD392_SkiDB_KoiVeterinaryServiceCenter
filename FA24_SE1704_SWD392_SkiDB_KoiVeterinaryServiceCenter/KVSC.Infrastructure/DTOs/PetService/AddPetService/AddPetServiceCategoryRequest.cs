using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.AddPetService
{
    public class AddPetServiceCategoryRequest
    {
        public string Name { get; set; } // Tên danh mục dịch vụ thú cưng
        public string Description { get; set; } // Mô tả 
        public string ServiceType { get; set; } // Loại dịch vụ
        public string ApplicableTo { get; set; } // Áp dụng cho loại pet nào
    }
}
