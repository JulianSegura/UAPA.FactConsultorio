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
        //private UnitOfWork _UoW;
        private PatientService _patientService;
        public FormPatients()
        {
            InitializeComponent();
            //_UoW = new UnitOfWork();
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
            using (Form patientEditor=new FormPatientEditor())
            {
                CenterToParent();
                patientEditor.ShowDialog(this); 
            }
        }
    }
}
