using System;

namespace UAPA.FactConsultorio.Domain.Interfaces
{
    interface IAuditable
    {
        DateTime DateCreated { get; set; }
        int UpdatedBy { get; set; }
        DateTime DateUpdated { get; set; }
    }
}