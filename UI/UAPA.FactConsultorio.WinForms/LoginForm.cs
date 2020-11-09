using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAPA.FactConsultorio.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool InvalidField()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}