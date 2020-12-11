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

        public UnitOfWork()
        {
            if (_context==null) _context = new DataContext();
        }

        public IRepository<User> UsersRepo => _usersRepo??=new GenericRepository<User>(_context);
        public IRepository<Patient> PatientsRepo => _patientsRepo ?? new GenericRepository<Patient>(_context);

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
