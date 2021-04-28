using PlayerUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillUsuario();
            if (true)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifica tus datos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FillUsuario()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.User = txtUsername.Text.Trim();
            oUsuario.Clave = txtPassword.Text.Trim();

        }
    }
}
