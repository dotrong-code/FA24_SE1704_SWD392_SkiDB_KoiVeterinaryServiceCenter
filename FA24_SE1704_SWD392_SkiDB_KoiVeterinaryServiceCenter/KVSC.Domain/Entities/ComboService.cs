using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class ComboService : BaseEntity
    {
        public string Name { get; set; } // Name of the combo
        public decimal DiscountPercentage { get; set; } // Discount percentage for the combo

        // Relationships
        public ICollection<ComboServiceItem> ComboServiceItems { get; set; } // List of services in the combo
        public decimal TotalPrice => ComboServiceItems?.Sum(csi => csi.PetService.BasePrice) * (1 - DiscountPercentage / 100) ?? 0;
    }
}
