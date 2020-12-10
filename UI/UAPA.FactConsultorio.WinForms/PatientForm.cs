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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
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
    }
}
