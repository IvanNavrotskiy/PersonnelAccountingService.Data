using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingService.Data.Entities
{
    public class Position : BaseEntity
    {
        public Organization Organization { get; set; }
        public string Name { get; set; }
    }
}
