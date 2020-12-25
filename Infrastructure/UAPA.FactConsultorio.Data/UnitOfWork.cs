using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IRepository<User> _usersRepo;
        private IRepository<Patient> _patientsRepo;
        private IRepository<Receipt> _receiptsRepo;
        private IRepository<Payment> _paymentsRepo;
        private IRepository<Service> _servicesRepo;

        public UnitOfWork()
        {
            if (_context==null) _context = new DataContext();
        }

        public IRepository<User> UsersRepo => _usersRepo??=new GenericRepository<User>(_context);
        public IRepository<Patient> PatientsRepo => _patientsRepo??= new GenericRepository<Patient>(_context);
        public IRepository<Receipt> ReceiptsRepo => _receiptsRepo ??= new GenericRepository<Receipt>(_context);
        public IRepository<Payment> PaymentsRepo => _paymentsRepo ??= new GenericRepository<Payment>(_context);
        public IRepository<Service> ServicesRepo => _servicesRepo ??= new GenericRepository<Service>(_context);

        public void Complete()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
