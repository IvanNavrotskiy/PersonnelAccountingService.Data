using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingService.Data.Entities.Documents
{
    public class BaseDocument : BaseEntity
    {
        public bool IsApproved { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
