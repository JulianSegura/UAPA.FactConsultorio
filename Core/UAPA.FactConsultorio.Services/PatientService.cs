using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Services
{
    public class PatientService
    {
        private IRepository<Patient> _patientsRepo;
        private readonly IUnitOfWork _UoW;

        public PatientService(IUnitOfWork UoW)
        {
            _UoW = UoW;
            _patientsRepo = _UoW.PatientsRepo;
        }

        public List<Patient> GetAll()
        {
            return _patientsRepo.GetAll().ToList();
        }
    }
}
