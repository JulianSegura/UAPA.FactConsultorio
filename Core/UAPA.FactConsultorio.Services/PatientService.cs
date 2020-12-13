using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Services
{
    public class PatientService
    {
        private readonly IUnitOfWork _UoW;
        private IRepository<Patient> _patientsRepo;
        private IRepository<Receipt> _receiptsRepo;

        public PatientService(IUnitOfWork UoW)
        {
            _UoW = UoW;
            _patientsRepo = _UoW.PatientsRepo;
        }

        public List<Patient> GetAll()
        {
            return _patientsRepo.GetAll().ToList();
        }

        public bool Add(Patient p)
        {
            p.Name = p.Name.ToUpper();
            p.Email = p.Email.ToUpper();
            try
            {
                _patientsRepo.Add(p);
                _UoW.Complete();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Patient GetById(int id)
        {
            return _patientsRepo.GetById(id);
        }

        public bool Update(Patient p)
        {
            p.Name = p.Name.ToUpper();
            p.Email = p.Email.ToUpper();
            try
            {
                _patientsRepo.Update(p, LoggedUser.UserId);
                _UoW.Complete();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Patient> GetByName(string name)
        {
            return _patientsRepo.Get(p => p.Name.Contains(name.ToUpper())).ToList();
        }

        public string Delete(int patientId)
        {
            _receiptsRepo = _UoW.ReceiptsRepo;
            var hasReceipts = _receiptsRepo.Get(r => r.Patient.Id == patientId).Any();
            if (!hasReceipts)
            {
                _patientsRepo.Remove(patientId);
                _UoW.Complete();
                return "Removed";
            }
            else
            {
                _patientsRepo.Delete(patientId, LoggedUser.UserId);
                _UoW.Complete();
                return "Disabled";
            }
        }
    }
}