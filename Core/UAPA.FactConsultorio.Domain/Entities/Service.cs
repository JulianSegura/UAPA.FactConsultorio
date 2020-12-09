using System;
using System.Collections.Generic;
using System.Text;

namespace UAPA.FactConsultorio.Domain.Entities
{
    public class Service:AuditableEntityBase
    {
        public string Area { get; set; }
        public string Specialty { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}