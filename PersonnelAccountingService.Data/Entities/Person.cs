using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingService.Data.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Surname} {Name} {Patronymic}".Trim();
        }
    }
}
