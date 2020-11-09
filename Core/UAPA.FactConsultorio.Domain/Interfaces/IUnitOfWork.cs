using System;
using System.Collections.Generic;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;

namespace UAPA.FactConsultorio.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UsersRepo { get;}

        void Complete();
    }
}
