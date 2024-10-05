using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.AddComboService
{
    public class AddComboServiceRequest
    {
        public string Name { get; set; }
        public decimal DiscountPercentage { get; set; }
        public List<Guid> ServiceIds { get; set; }
    }
}
