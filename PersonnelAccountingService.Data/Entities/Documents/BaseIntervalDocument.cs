using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingService.Data.Entities.Documents
{
    public class BaseIntervalDocument : BaseDocument
    {
        public bool IsActive()
        {
            return IsActive(DateTime.UtcNow);
        }
        public virtual bool IsActive(DateTime dateTimeUtc)
        {
            return (StartDateTimeUtc <= dateTimeUtc) && (dateTimeUtc <= EndDateTimeUtc);
        }

        public DateTime StartDateTimeUtc { get; set; }
        public DateTime EndDateTimeUtc { get; set; }
    }
}
