using System;
using System.Collections.Generic;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;

namespace UAPA.FactConsultorio.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UsersRepo { get;}
        IRepository<Patient> PatientsRepo { get; }
        IRepository<Receipt> ReceiptsRepo { get; }
        IRepository<Payment> PaymentsRepo { get; }
        IRepository<Service> ServicesRepo { get;}

        void Complete();
    }
}
