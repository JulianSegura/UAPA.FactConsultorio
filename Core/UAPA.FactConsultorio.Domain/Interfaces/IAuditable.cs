using System;

namespace UAPA.FactConsultorio.Domain.Interfaces
{
    interface IAuditable
    {
        int CreatedBy { get; set; }
        DateTime DateCreated { get; set; }
        int UpdatedBy { get; set; }
        DateTime DateUpdated { get; set; }
    }
}