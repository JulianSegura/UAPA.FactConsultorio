using System;
using System.Collections.Generic;
using System.Text;

namespace UAPA.FactConsultorio.Domain.Entities
{
    public class Patient:AuditableEntityBase
    {
        public string Name { get; set; }
        public DateTime BithDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
