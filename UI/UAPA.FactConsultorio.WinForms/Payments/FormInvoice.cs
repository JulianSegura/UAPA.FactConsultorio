using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAPA.FactConsultorio.Data;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Services;
using UAPA.FactConsultorio.WinForms.Patients;

namespace UAPA.FactConsultorio.WinForms.Payments
{
    public partial class FormInvoice : Form
    {
        //PatientService _patientsService = new PatientService(new UnitOfWork());
        private PaymentService _paymentService = new PaymentService(new UnitOfWork());
        private bool formLoading;//used to indicate form first run.
        private string serviceArea;

        public FormInvoice()
        {
            InitializeComponent();
        }

        private void pbCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ToolTip closeTip = new ToolTip();
            closeTip.SetToolTip(pbCloseForm, "Salir");
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            formLoading = true;
            FillPatientsCombo();
            formLoading = false;
        }

        private void FillPatientsCombo()
        {
            var patients = _paymentService.GetPatients();
            cmbPatient.DataSource = patients;
            cmbPatient.ValueMember = "Id";
            cmbPatient.DisplayMember = "Name";
            cmbPatient.Text = "Nombre Paciente";
        }

        private void FillPatientData()
        {
            var selectedPatient = (Patient)cmbPatient.SelectedItem;
            txtPhoneNumber.Text = selectedPatient.PhoneNumber;
            txtEmail.Text = selectedPatient.Email;
            txtAddress.Text = selectedPatient.BithDate.ToString();
        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoading) return;
            FillPatientData();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            //ToDo: MUST clear patient info if any selected
            using FormPatientEditor f = new FormPatientEditor(new PatientService(new UnitOfWork())); 
            CenterToParent();
            f.ShowDialog(this);
            FillPatientsCombo();
            //ToDo: MUST select patient added
        }

        private void radConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (!radConsulta.Checked) return;
            serviceArea = "Consulta";
            FillServicesCombo(_paymentService.GetServices(serviceArea));
        }

        private void radLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            if (!radLaboratorio.Checked) return;
            serviceArea = "Laboratorios";
            FillServicesCombo(_paymentService.GetServices(serviceArea));
        }

        private void radEspecialidades_CheckedChanged(object sender, EventArgs e)
        {
            if (!radEspecialidades.Checked) return;
            serviceArea = "Especialidades Medicas";
            FillAreaCombo();
        }

        private void FillAreaCombo()
        {
            var areas = _paymentService.GetServices().Where(s=>s.Area==serviceArea).Select(s=>s.Specialty).Distinct().ToList();
            cmbArea.DataSource = areas;
            cmbArea.DisplayMember = "Specialty";
            cmbArea.Text = "Seleccione Especialidad";
        }

        private void FillServicesCombo(List<Service> services)
        {
            
            cmbService.DataSource = services;
            cmbService.DisplayMember = "Name";
            cmbService.ValueMember = "Id";
            cmbService.Text = "Seleccione Servicio";
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea.Text == "Seleccione Especialidad") return;
            var services = _paymentService.GetServices(null , cmbArea.Text);
            serviceArea = cmbArea.Text;
            FillServicesCombo(services);
        }
    }
}
