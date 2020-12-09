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
    }
}