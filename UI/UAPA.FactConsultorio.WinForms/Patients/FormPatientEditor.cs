using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Services;

namespace UAPA.FactConsultorio.WinForms.Patients
{
    public partial class FormPatientEditor : Form
    {
        private readonly PatientService _patientService;
        private Patient _patient;
        public FormPatientEditor(PatientService service, Patient patient=null)
        {
            InitializeComponent();
            _patientService = service;
            _patient = patient;
        }
        private void RegisterPatient()
        {
            if (!InvalidFields()) return;

            _patient = new Patient
            {
                Name = txtPatientName.Text.Trim(),
                Enabled = true,
                BithDate=dtpBirthDate.Value.Date,
                PhoneNumber=txtPhoneNumber.Text.Trim(),
                Email=txtEmail.Text.Trim()
            };
            if (_patientService.Add(_patient))
            {
                MessageBox.Show("Paciente Registrado","FactConsulta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Al Registrar El Paciente", "FactConsulta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        private void UpdatePatient()
        {
            _patient.Name = txtPatientName.Text.Trim();
            _patient.BithDate = dtpBirthDate.Value.Date;
            _patient.PhoneNumber = txtPhoneNumber.Text.Trim();
            _patient.Email = txtEmail.Text.Trim();
            SetPatientStatus();

            if (_patientService.Update(_patient))
            {
                MessageBox.Show("Paciente Actualizado", "FactConsulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Al Actualizar El Paciente", "FactConsulta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        private bool InvalidFields()
        {
            if (txtPatientName.Text.Trim() == "") return false;
            if (dtpBirthDate.Value == DateTime.Today) return false;
            return true;
        }
        private void FormPatientEditor_Load(object sender, EventArgs e)
        {
            dtpBirthDate.MaxDate = DateTime.Today;
            dtpBirthDate.Value = DateTime.Today;
            txtPatientName.Focus();
            if (_patient != null)
            {
                lblPatientId.Text = _patient.Id.ToString();
                txtPatientName.Text = _patient.Name;
                dtpBirthDate.Value = _patient.BithDate;
                txtPhoneNumber.Text = _patient.PhoneNumber;
                txtEmail.Text = _patient.Email;
                radEnabled.Checked = _patient.Enabled;
                radDisabled.Checked = !_patient.Enabled;
            }
        }
        private void SetPatientStatus()
        {
            if (radEnabled.Checked == true) _patient.Enabled = true;
            else _patient.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_patient == null) RegisterPatient();
            else UpdatePatient();
        }
        private void ClearForm()
        {
            txtPatientName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            radEnabled.Checked = true;
            radDisabled.Checked = false;
            lblPatientId.Text = "0";
            dtpBirthDate.Value = DateTime.Today;
            txtPatientName.Focus();
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}