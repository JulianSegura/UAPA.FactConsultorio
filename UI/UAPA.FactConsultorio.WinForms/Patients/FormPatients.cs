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

namespace UAPA.FactConsultorio.WinForms.Patients
{
    public partial class FormPatients : Form
    {
        //ToDo: Arreglar el Tab Order para flujo sin teclado
        private PatientService _patientService;
        public FormPatients()
        {
            InitializeComponent();
            _patientService = new PatientService(new UnitOfWork());
        }

        private void pbCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ToolTip closeTip = new ToolTip();
            closeTip.SetToolTip(pbCloseForm, "Salir");
        }

        private void pbCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            lblSearch.Location = new Point(-4, 62);
            txtSearch.Location = new Point(0, 82);
            FillDataGrid();
        }

        private void FillDataGrid(List<Patient> data=null)
        {
            dtgPatientsDetails.Rows.Clear();

            if (data == null) data = _patientService.GetAll();

            foreach (var patient in data)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgPatientsDetails);
                newRow.SetValues(
                    patient.Id,
                    patient.Name,
                    patient.BithDate,
                    patient.PhoneNumber,
                    patient.Email,
                    patient.Enabled);
                dtgPatientsDetails.Rows.Add(newRow);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (Form patientEditor=new FormPatientEditor(_patientService))
            {
                CenterToParent();
                patientEditor.ShowDialog(this);
                FillDataGrid();
            }
        }

        private void UpdatePatient()
        {
            int patientId = Convert.ToInt32(dtgPatientsDetails.SelectedRows[0].Cells["PatientId"].Value);
            var patient = _patientService.GetById(patientId);

            using (Form patientEditor = new FormPatientEditor(_patientService, patient))
            {
                CenterToParent();
                patientEditor.ShowDialog(this);
                FillDataGrid();
            };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdatePatient();
        }

        private void dtgPatientsDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePatient();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text=="Buscar paciente...")
            {
                lblSearch.Visible = true;
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                lblSearch.Visible = false;
                txtSearch.Text = "Buscar paciente...";
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)&&txtSearch.Text.Trim()!="")
            {
                SearchPatients();
            }
        }

        private void SearchPatients()
        {
            string searchParam = txtSearch.Text.Trim();
            var patients = _patientService.GetByName(searchParam);
            FillDataGrid(patients);
            //ToDo: Agregar funcion para resetear el datagrid cuando se quiera volver a ver toda la lista de pacientes. 
        }

        private void DeletePatient()
        {
            int patientId = Convert.ToInt32(dtgPatientsDetails.SelectedRows[0].Cells["PatientId"].Value);

            var result = _patientService.Delete(patientId);
            if (result == "Removed") MessageBox.Show("Paciente Eliminado", "FactConsulta", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (result== "Disabled") MessageBox.Show("Existen Recibos A Nombre De Este Paciente, No Se Puede Eliminar\nPaciente Inactivado", "FactConsulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FillDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePatient();
        }
    }
}
