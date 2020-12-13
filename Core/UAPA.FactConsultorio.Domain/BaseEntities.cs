using System;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Domain
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool Enabled { get; set; }
    }

    public class AuditableEntityBase : EntityBase, IAuditable
    {
        public DateTime DateCreated { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}