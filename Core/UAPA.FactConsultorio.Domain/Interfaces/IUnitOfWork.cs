using System;
using System.Collections.Generic;
using System.Text;

namespace UAPA.FactConsultorio.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
    }
}
