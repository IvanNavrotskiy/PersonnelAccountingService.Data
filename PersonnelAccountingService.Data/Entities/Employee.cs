using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingService.Data.Entities
{
    public class Employee : BaseEntity
    {
        public Organization Organization { get; set; }
        public Person Person { get; set; }
        public Position Position { get; set; }
    }
}
