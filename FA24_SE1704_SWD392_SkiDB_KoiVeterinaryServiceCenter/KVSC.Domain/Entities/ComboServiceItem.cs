using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class ComboServiceItem : BaseEntity
    {
        public Guid ComboServiceId { get; set; } 
        public Guid PetServiceId { get; set; } 

        // Relationships
        public ComboService ComboService { get; set; }
        public PetService PetService { get; set; }
    }
}
