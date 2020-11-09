
namespace UAPA.FactConsultorio.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSysAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnInvoicing = new System.Windows.Forms.Button();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnSysAdmin);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.btnPatients);
            this.pnlMenu.Controls.Add(this.btnInvoicing);
            this.pnlMenu.Controls.Add(this.pnlUserInfo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(191, 542);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSysAdmin
            // 
            this.btnSysAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnSysAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSysAdmin.FlatAppearance.BorderSize = 0;
            this.btnSysAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSysAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSysAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSysAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnSysAdmin.Image")));
            this.btnSysAdmin.Location = new System.Drawing.Point(0, 322);
            this.btnSysAdmin.Name = "btnSysAdmin";
            this.btnSysAdmin.Size = new System.Drawing.Size(191, 50);
            this.btnSysAdmin.TabIndex = 4;
            this.btnSysAdmin.Text = "Adm. Sistema";
            this.btnSysAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSysAdmin.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Informes";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.SystemColors.Control;
            this.btnPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.Location = new System.Drawing.Point(0, 222);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(191, 50);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "Pacientes";
            this.btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatients.UseVisualStyleBackColor = false;
            // 
            // btnInvoicing
            // 
            this.btnInvoicing.BackColor = System.Drawing.SystemColors.Control;
            this.btnInvoicing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoicing.FlatAppearance.BorderSize = 0;
            this.btnInvoicing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoicing.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicing.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInvoicing.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoicing.Image")));
            this.btnInvoicing.Location = new System.Drawing.Point(0, 172);
            this.btnInvoicing.Name = "btnInvoicing";
            this.btnInvoicing.Size = new System.Drawing.Size(191, 50);
            this.btnInvoicing.TabIndex = 1;
            this.btnInvoicing.Text = "Facturacion";
            this.btnInvoicing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoicing.UseVisualStyleBackColor = false;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.lblUserRole);
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Controls.Add(this.pbUserPicture);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(191, 172);
            this.pnlUserInfo.TabIndex = 0;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserRole.Location = new System.Drawing.Point(3, 123);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(85, 20);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Rol Usuario";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserName.Location = new System.Drawing.Point(3, 103);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(123, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Nombre Usuario";
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbUserPicture.Image")));
            this.pbUserPicture.Location = new System.Drawing.Point(1, 0);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(117, 100);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPicture.TabIndex = 0;
            this.pbUserPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1021, 542);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAPA - Facturacion Consultorio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Button btnInvoicing;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.Button btnSysAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPatients;
    }
}

