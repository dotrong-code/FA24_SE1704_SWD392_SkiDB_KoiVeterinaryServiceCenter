using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.AddComboService
{
    public class ComboServiceResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountPercentage { get; set; }
        public List<Guid> ServiceIds { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
