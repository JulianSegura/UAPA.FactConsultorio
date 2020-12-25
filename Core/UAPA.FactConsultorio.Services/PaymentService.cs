using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Domain.Interfaces;

namespace UAPA.FactConsultorio.Services
{
    public class PaymentService
    {
        private readonly IUnitOfWork _UoW;
        private readonly IRepository<Receipt> _receiptsRepo;
        //private IRepository<ReceiptLine> _receiptDetailsRepo;
        private readonly IRepository<Payment> _paymentsRepo;
        private readonly IRepository<Service> _servicesRepo;
        private PatientService _patientService;

        public PaymentService(IUnitOfWork UoW)
        {
            _UoW = UoW;
            _receiptsRepo = _UoW.ReceiptsRepo;
            _paymentsRepo = _UoW.PaymentsRepo;
            _servicesRepo = _UoW.ServicesRepo;
            _patientService = new PatientService(_UoW);
        }

        public List<Patient> GetPatients()
        {
            return _patientService.GetAll();
        }

        public List<Service> GetServices(string area=null,string specialty=null)
        {
            if (area == null && specialty==null) return _servicesRepo.GetAll().Where(s=>s.Enabled==true).ToList();
            if (area!=null) return _servicesRepo.Get(s => s.Area == area && s.Enabled==true).ToList();
            return _servicesRepo.Get(s => s.Specialty == specialty & s.Enabled == true).ToList();
        }
    }
}
