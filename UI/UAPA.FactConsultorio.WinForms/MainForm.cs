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
using UAPA.FactConsultorio.Domain.Enums;
using UAPA.FactConsultorio.WinForms.Patients;

namespace UAPA.FactConsultorio.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ValidateUser();
        }

        private void ValidateUser()
        {
            if (LoggedUser.Role == nameof(UserRoles.Cashier))
            {
                btnSysAdmin.Visible = false;
                btnReports.Visible = false;
            }
            lblUserName.Text = LoggedUser.Name;
            lblUserRole.Text = LoggedUser.Role;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm<F>() where F: Form,new()
        {
            var childForm = pnlWorkingArea.Controls.OfType<F>().FirstOrDefault();
            if (childForm == null)
            {
                childForm = new F
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                pnlWorkingArea.Controls.Add(childForm);
                pnlWorkingArea.Tag = childForm;
            }

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            OpenChildForm<FormPatients>();
        }
    }
}