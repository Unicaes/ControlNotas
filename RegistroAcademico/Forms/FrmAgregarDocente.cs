using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PlayerUI.Model;

namespace PlayerUI
{
    public partial class FrmAgregarDocente : Form
    {
        public FrmAgregarDocente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Interaction.InputBox("Ingresa el Documento del docente", "Búsqueda de Docente", "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtClave.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar == '*')
            {
                button3.BringToFront();
                txtClave.PasswordChar = '\0';
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Aquí va el put al api xDXDXD
        }

        private void FillDocente()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Nombre = txtNombre.Text.Trim();
            oUsuario.Apellido = txtApellido.Text.Trim();
            oUsuario.User = txtUsuario.Text.Trim();
            oUsuario.Clave = txtClave.Text.Trim();
            oUsuario.Telefono = txtTelefono.Text.Trim();
            oUsuario.Direccion = txtDireccion.Text.Trim();
            oUsuario.Documento = txtDocumento.Text.Trim();
        }
    }
}
