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
using UAPA.FactConsultorio.Domain.DTOs;
using UAPA.FactConsultorio.Services;

namespace UAPA.FactConsultorio.WinForms
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;
        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService(new UnitOfWork());
        }

        private bool FieldNotValid()
        {
            if (txtUserName.Text.Trim() == "")
            {
                ErrorMessage("Ingrese Usuario");
                return true;
            }
            if (txtPassword.Text.Trim() == "")
            {
                ErrorMessage("Ingrese Contraseña");
                return true;
            }

            return false;
        }

        private void ErrorMessage(string msg)
        {
            lblErrorMessage.Text = "X " + msg;
            lblErrorMessage.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (FieldNotValid()) return;

            LoginInfo loginInfo = new LoginInfo { UserName = txtUserName.Text.Trim(), Password = txtPassword.Text.Trim() };
            var validLogin = userService.Login(loginInfo);

            if (validLogin)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                ErrorMessage("Error al acceder. Verifique Usuario o Contraseña");
            }
        }
    }
}